using System.Web;
using System.Web.Optimization;

namespace ClashLootWebpage
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.UseCdn = true;   //enable CDN support
            //var bootstrapTablePathJS = "//cdnjs.cloudflare.com/ajax/libs/bootstrap-table/1.12.1/bootstrap-table.min.js";
            //var bootstrapTablePathCSS = "//cdnjs.cloudflare.com/ajax/libs/bootstrap-table/1.12.1/bootstrap-table.min.css";

            //************** JS BUNDLES *******************
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/scripts/bootstrap-table/bootstrap-table.min.js",
                      "~/Scripts/respond.js"));            
            /*
            bundles.Add(new ScriptBundle("~/bundles/bootstrap-table",
                       bootstrapTablePathJS).Include(
                      "~/Scripts/bootstrap-table.js"));
            */

            //************** CSS BUNDLES *******************
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.css",
                      "~/content/bootstrap-table.min.css",
                      "~/Content/site.css"));
            /*
            bundles.Add(new StyleBundle("~/Content/css-table",
                       bootstrapTablePathCSS).Include(
                      "~/Content/bootstrap-table.css"));
            */
            //BundleTable.EnableOptimizations = true;

        }
    }
}
