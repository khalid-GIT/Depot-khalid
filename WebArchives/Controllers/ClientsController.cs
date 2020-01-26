﻿using BLL;
using COMMON.DTO.Clients;
using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WebForms.Internal.Soap.ReportingServices2005.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebArchives.Filtres;
using WebArchives.Models.Clients;
using Warning = Microsoft.Reporting.WebForms.Warning;

namespace WebArchives.Controllers
{
   // [Auth]
    public class ClientsController : Controller
    {
        // GET: Clients
        public ActionResult Index(VMListeClient model)
        {
            var bis = new BusinessClients();
            model.listeclients = bis.BusinessliseClient();
            //var bisFamille = new BusinessFamilleClients();
            var biz = new BusinessVilles();
            var bizF = new BusinessFamilleClients();
            var bizContact = new BusinessContactClt();
            model.ListeContact = bizContact.ListContact();
            model.listeVilles = biz.GetListeVille();
            model.listeFamille = bizF.GetListFamilleClt();

            //model.listeFamille = bisFamille.GetListFamilleClt();

            //return View(model);
            var data = model.listeclients;
         return View(model);
            //return Json(new { data }, JsonRequestBehavior.AllowGet);
           // return Json(new { data }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetlisteClient(VMListeClient model)
        {
            var biz = new BusinessClients();
            model.listeclients = biz.BusinessliseClient();
            var clients = model.listeclients;
            //return View(model);
            return Json(new { clients }, JsonRequestBehavior.AllowGet);

        }
        // GET: Clients/Details/5
        public ActionResult Details(int id)
        {
            var biz = new BusinessClients();

            var dto = biz.GetClientById(id);

            var model = new VMListeClient
            {
                id = dto.id,
                Nom = dto.Nom,
                telephone1 = dto.telephone1,
                Adresse = dto.Adresse,
                fax = dto.fax,
                Mail = dto.Mail,
                Cnss = dto.Cnss,
                idf = dto.idf,
                Ice = dto.Ice,
                Gsm = dto.Gsm,
                Teleph = dto.Teleph,
            };


            return View(model);
        }

        // GET: Clients/Create
        public JsonResult Create()
        {

            try
            {
                var model = new VMListeClient();
                var biz = new BusinessVilles();
                var bizF = new BusinessFamilleClients();
                var bizContact = new BusinessContactClt();
                model.ListeContact = bizContact.ListContact();
                model.listeVilles = biz.GetListeVille();
                model.listeFamille = bizF.GetListFamilleClt();
                //return View(model);
                ModelState.Remove("Name");
                return Json(model, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Report(string repotType)
        {
            LocalReport Lr = new LocalReport();
            String path = Path.Combine(Server.MapPath("~/Reports"), "Report1.rdlc");

            if (System.IO.File.Exists(path))
            {
                Lr.ReportPath = path;

            }
            else
            {
                return RedirectToAction("index");

            }
            var bis = new BusinessClients();
            var model = new VMListeClient();
            var list = bis.BusinessliseViewClient();
            //var list = model.listeclients;

            ReportDataSource rd = new ReportDataSource("DataSet1", list);
            
            Lr.DataSources.Add(rd);
            //string reportType = id;
            string mimeType;
            string encoding;
            string fileNameExtension;

            switch (repotType)
            {
                case "Excel":
                    fileNameExtension = "xlsx";
                    break;
                case "Word":
                    fileNameExtension = "docs";
                    break;
                case "PDF":
                    fileNameExtension = "pdf";
                    break;
                default:
                    fileNameExtension = "jpg";
                    break;
            }

            string deviceinfo =
                "<deviceInfo>" +
                "<outPutFormat>" + repotType + "</outPutFormat>" +
                "<PageWidth>8.5in</outPutFormat>" +
                "<PageHeiht>11in</PageHeiht>" +
                "<MarginTop>0.5in</MarginTop>" +
                "<MarginLeft>1in</MarginLeft>" +
                "<MarginRight>1in</MarginLeft>" +
                "<MarginBottom>0,5in</MarginBottom>" +
                "<deviceInfo>";

            Warning[] warnings;
            string[] streams;
            byte[] renderBytes;

            renderBytes = Lr.Render(
                repotType,
                "",
                out mimeType,
                out encoding,
                out fileNameExtension,
                out streams,
                out warnings
                );
            return File(renderBytes, mimeType);
        }
        // POST: Clients/Create Ancienne méthode avec formulaire
        //[HttpPost]
        //public ActionResult Create(VMListeClient model)
        //{
        //    var bizF = new BusinessFamilleClients();
        //    try
        //    {
        //        if (ModelState.IsValid == true)
        //        {
        //            var dto = new DtoListeClients();
        //                dto.Nom = model.Nom;
        //                dto.Adresse = model.Nom;
        //                dto.Mail = model.Mail;
        //                dto.telephone1 = model.telephone1;
        //                dto.fax = model.fax;
        //                dto.idf = model.idf;
        //                dto.Ice = model.Ice;
        //                dto.Gsm = model.Gsm;
        //                dto.Teleph = model.Teleph;
        //                dto.Gsm = model.Gsm;
        //                dto.Tbl_Famille_Clt_Id = model.Tbl_Famille_Clt_Id;
        //                dto.Tbl_Ville_id = model.Tbl_Ville_id;
        //                dto.IDContact = model.IDContact;

            //            var bizv = new BusinessVilles();
            //            var bizContact = new BusinessContactClt();


            //            model.ListeContact = bizContact.ListContact();
            //            model.listeVilles = bizv.GetListeVille();
            //            model.listeFamille = bizF.GetListFamilleClt();


            //            var biz = new BusinessClients();
            //            biz.AjouterClient(dto);
            //            return RedirectToAction("index");
            //        }
            //        return View(model);
            //    }
            //    catch(Exception e)
            //    {
            //        return View(model);
            //    }
            //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Create(VMListeClient model)
        {
            var bizF = new BusinessFamilleClients();
            var bis = new BusinessClients();

            try
            {
                if (ModelState.IsValid == true)
                {
                    var dto = new DtoListeClients();
                    dto.Nom = model.Nom;
                    dto.Adresse = model.Adresse;
                    dto.Mail = model.Mail;
                    dto.telephone1 = model.telephone1;
                    dto.fax = model.fax;
                    dto.idf = model.idf;
                    dto.Ice = model.Ice;
                    dto.Cnss = model.Cnss;
                    //dto.Teleph = model.Teleph;
                    dto.Gsm = model.Gsm;
                    dto.Tbl_Famille_Clt_Id = model.Tbl_Famille_Clt_Id;
                    //dto.Tbl_Famille_Clt_Id = 1;
                    dto.Tbl_Ville_id = model.Tbl_Ville_id;
                    //dto.Tbl_Ville_id = 1;
                    dto.IDContact = model.IDContact;
                    //dto.IDContact = 1;

                    var bizv = new BusinessVilles();
                    var bizContact = new BusinessContactClt();


                    model.ListeContact = bizContact.ListContact();
                    model.listeVilles = bizv.GetListeVille();
                    model.listeFamille = bizF.GetListFamilleClt();

                    var biz = new BusinessClients();
                    int id = biz.AjouterClient(dto);
                    var clients = bis.BusinessliseClient();
                    //return RedirectToAction("index");
                    return Json(clients, JsonRequestBehavior.AllowGet);
                }
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            catch (Exception )
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        // GET: Clients/Edit/5
        public JsonResult Edit(int id)
        {
            var biz = new BusinessClients();
            var dto = biz.GetClientById(id);
            var model = new VMListeClient
            {
                id = dto.id,
                Nom = dto.Nom,
                telephone1 = dto.telephone1,
                Adresse = dto.Adresse,
                fax = dto.fax,
                Mail = dto.Mail,
                Cnss = dto.Cnss,
                idf = dto.idf,
                Ice = dto.Ice,
                Gsm = dto.Gsm,
                Teleph = dto.Teleph,
                Tbl_Famille_Clt_Id = dto.Tbl_Famille_Clt_Id,
                Tbl_Ville_id = dto.Tbl_Ville_id,
                IDContact = dto.IDContact
            };
            var bizV = new BusinessVilles();
            var bizF = new BusinessFamilleClients();
            var bizContact = new BusinessContactClt();
            model.ListeContact = bizContact.ListContact();
            model.listeVilles = bizV.GetListeVille();
            model.listeFamille = bizF.GetListFamilleClt();
            return Json(new { model }, JsonRequestBehavior.AllowGet);
            //return View(model);
        }

        // POST: Clients/Edit/5
        [HttpPost]
        public ActionResult Edit(VMListeClient model)
        {
            var biz = new BusinessClients();
           var  IsUpdate = false;
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    IsUpdate = true;
                    var dto = new DtoListeClients();
                    dto.id = model.id;
                    dto.Nom = model.Nom;
                    dto.Adresse = model.Adresse;
                    dto.Mail = model.Mail;
                    dto.telephone1 = model.telephone1;
                    dto.fax = model.fax;
                    dto.idf = model.idf;
                    dto.Ice = model.Ice;
                    dto.Gsm = model.Gsm;
                    dto.Teleph = model.Teleph;
                    dto.Cnss = model.Cnss;
                    dto.Tbl_Famille_Clt_Id = model.Tbl_Famille_Clt_Id;
                    dto.Tbl_Ville_id = model.Tbl_Ville_id;
                    dto.IDContact = model.IDContact;
                  
                    biz.MdifierClient(dto);

                }

                var bizV = new BusinessVilles();
                var bizF = new BusinessFamilleClients();
                var bizContact = new BusinessContactClt();
              

                model.ListeContact = bizContact.ListContact();
                model.listeVilles = bizV.GetListeVille();
                model.listeFamille = bizF.GetListFamilleClt();
                var clients = biz.BusinessliseClient();

                return Json(new { clients, IsUpdate ,message="Success" }, JsonRequestBehavior.AllowGet);
            
         }
            catch
            {
                return Json( null, JsonRequestBehavior.AllowGet);
            }
        }

        //[Filtre1]
        public JsonResult Delete(int id)
        {
            try
            {
                var biz = new BusinessClients();
                biz.SupprimerClients(id);
                //message de confirmation
                //TempData["SuccessMessage"] = "La ville a eté supprimée avec succés";
                //var biz = new BusinessClients();
                //int id = biz.AjouterClient(dto);
                var clients = biz.BusinessliseClient();
                return Json(new { clients,IsDeleted=true }, JsonRequestBehavior.AllowGet);
                //return RedirectToAction("index");
                //return View();
            }
            catch
            {
                return Json(null, JsonRequestBehavior.AllowGet);

            }
        }
        public JsonResult Chercher(string chercher)
        {

            var biz = new BusinessClients();
            
            var clients = biz.BusinessliseClient();
            return Json(new { clients, IsDeleted = true }, JsonRequestBehavior.AllowGet);

        }
    }
}
