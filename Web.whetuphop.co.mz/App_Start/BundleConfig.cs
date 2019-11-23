using System.Web;
using System.Web.Optimization;

namespace Standarbank.jue.web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
             "~/admin-lte/js/adminlte.js",
            "~/admin-lte/plugins/iCheck/icheck.js",
            "~/admin-lte/plugins/input-mask/jquery.inputmask.js",
            "~/admin-lte/plugins/input-mask/jquery.inputmask.date.extensions.js",
            "~/admin-lte/plugins/input-mask/jquery.inputmask.extensions.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.css",
                      "~/admin-lte/css/AdminLTE.css",
                      "~/admin-lte/css/alt/AdminLTE-select2.css",
                      "~/admin-lte/css/skins/_all-skins.css",
                      "~/admin-lte/plugins/iCheck/square/blue.css"));
        }
    }
}
