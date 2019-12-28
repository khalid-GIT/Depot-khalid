using System.Web;
using System.Web.Optimization;

namespace Edtrust.Risk
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //CSS
            bundles.Add(new StyleBundle("~/Content/bootstrap/css").Include(
                      "~/Content/bootstrap.css",
                      //"~/Content/bootstrap-social.css",
                      "~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/metisMenu/css").Include(
                      "~/Content/metisMenu.css"));

            bundles.Add(new StyleBundle("~/Content/timeline/css").Include(
                      "~/Content/timeline.css"));

            bundles.Add(new StyleBundle("~/Content/startmin/css").Include(
                      "~/Content/startmin.css"));

            bundles.Add(new StyleBundle("~/Content/morris/css").Include(
                      "~/Content/morris.css"));

            bundles.Add(new StyleBundle("~/datatable/css").Include(
                      "~/Content/dataTables/datatables.min.css",
                      "~/Content/dataTables/jquery.dataTables.min.css"));

            bundles.Add(new StyleBundle("~/datatable/buttons/css").Include(
                      "~/Content/dataTables/Buttons-1.5.1/css/buttons.bootstrap.css",
                      "~/Content/dataTables/Buttons-1.5.1/css/buttons.bootstrap4.css",
                      "~/Content/dataTables/Buttons-1.5.1/css/buttons.foundation.css",
                      "~/Content/dataTables/Buttons-1.5.1/css/buttons.jqueryui.css",
                      "~/Content/dataTables/Buttons-1.5.1/css/buttons.semanticui.css",
                      "~/Content/dataTables/Buttons-1.5.1/css/buttons.bootstrap.min.css",
                      "~/Content/dataTables/Buttons-1.5.1/css/buttons.dataTables.css"));

            bundles.Add(new StyleBundle("~/Content/fontawesome/css").Include(
                "~/Content/font-awesome.min.css"
                ));

            bundles.Add(new StyleBundle("~/Content/Risk/css").Include(
                "~/Content/Risk.css"
                ));

            bundles.Add(new StyleBundle("~/Content/jquery-ui.min/css").Include(
               "~/Content/jquery-ui.min.css"
               ));

            bundles.Add(new StyleBundle("~/Content/jquery-ui/css").Include(
               "~/Content/jquery-ui.css"
               ));

            bundles.Add(new StyleBundle("~/Content/datetimepicker/css").Include(
               "~/Content/bootstrap-datetimepicker.css"
               ));

            //JAVASCRIPTS

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"
                      ));

            bundles.Add(new ScriptBundle("~/datatable/buttons/js").Include(
                "~/Scripts/dataTables/Buttons-1.5.1/js/dataTables.buttons.js",
                "~/Scripts/dataTables/Buttons-1.5.1/js/buttons.flash.js",
                "~/Scripts/dataTables/Buttons-1.5.1/js/buttons.colVis.js",
                "~/Scripts/dataTables/Buttons-1.5.1/js/buttons.html5.js",
                "~/Scripts/dataTables/Buttons-1.5.1/js/buttons.bootstrap.js",
                "~/Scripts/dataTables/Buttons-1.5.1/js/buttons.bootstrap4.js",
                "~/Scripts/dataTables/Buttons-1.5.1/js/buttons.foundation.js",
                "~/Scripts/dataTables/Buttons-1.5.1/js/buttons.jqueryui.js",
                "~/Scripts/dataTables/Buttons-1.5.1/js/buttons.semanticui.js",
                "~/Scripts/dataTables/Buttons-1.5.1/js/buttons.print.js"));

            bundles.Add(new ScriptBundle("~/datatable/js").Include(
                "~/Scripts/dataTables/datatables.min.js",
                "~/Scripts/dataTables/jquery.dataTables.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/raphael/js").Include(
                "~/Scripts/raphael.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/metisMenu/js").Include(
                "~/Scripts/metisMenu.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/morris/js").Include(
                "~/Scripts/morris.min.js",
                "~/Scripts/morris-data.js"));

            bundles.Add(new ScriptBundle("~/bundles/startmin/js").Include(
                "~/Scripts/startmin.js"));

            bundles.Add(new ScriptBundle("~/bundles/home/js").Include(
                "~/Scripts/home.js"));

            bundles.Add(new ScriptBundle("~/bundles/Risk/js").Include(
                "~/Scripts/Risk.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapfd/js").Include(
                "~/Scripts/bootstrap.fd.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui.min/js").Include(
            "~/Scripts/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datetimepicker/js").Include(
            "~/Scripts/bootstrap-datetimepicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/Invoice/js").Include(
           "~/Scripts/Invoice.js"));

        }
    }
}
