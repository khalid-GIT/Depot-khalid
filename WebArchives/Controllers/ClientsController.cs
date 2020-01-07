using BLL;
using COMMON.DTO.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebArchives.Filtres;
using WebArchives.Models.Clients;

namespace WebArchives.Controllers
{
    //[Auth]
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
            var data = model.listeclients;
            //return View(model);
            return Json(new { data = data }, JsonRequestBehavior.AllowGet);

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
        public ActionResult Create()
        {
            var model = new VMListeClient();
            var biz = new BusinessVilles();
            var bizF = new BusinessFamilleClients();
            var bizContact = new BusinessContactClt();
            model.ListeContact = bizContact.ListContact();
            model.listeVilles = biz.GetListeVille();
            model.listeFamille = bizF.GetListFamilleClt();
            return View(model);
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
                    dto.Adresse = model.Nom;
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
            catch (Exception e)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int id)
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
            return View(model);
        }

        // POST: Clients/Edit/5
        [HttpPost]
        public ActionResult Edit(VMListeClient model)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    var dto = new DtoListeClients();
                    dto.id = model.id;
                    dto.Nom = model.Nom;
                    dto.Adresse = model.Nom;
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
                    var biz = new BusinessClients();
                    biz.MdifierClient(dto);

                }

                return RedirectToAction("index");
            }
            catch
            {
                return View();
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
                return Json("success", JsonRequestBehavior.AllowGet);
                //return RedirectToAction("index");
                //return View();
            }
            catch
            {
                return Json(null, JsonRequestBehavior.AllowGet);

            }
        }
    }
}
