using System.Web.Optimization;
namespace FitnessServices.web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Styles 
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                 "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/style/css").Include(
                "~/Content/css/style.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/chartist.min/css").Include(
                "vendor/chartist/css/chartist.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bootstrap-select.min/css").Include(
              "vendor/bootstrap-select/dist/css/bootstrap-select.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/LineIcons/css").Include(
             "~/Content/other/2.0/LineIcons.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/owl.carousel/css").Include(
             "~/Content/vendor/owl-carousel/owl.carousel.css", new CssRewriteUrlTransform()));
          

            //Scripts 
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                 "~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/global.min/js").Include(
                 "~/Content/vendor/global/global.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap-select.min/js").Include(
                "~/Content/vendor/bootstrap-select/dist/js/bootstrap-select.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/custom.min/js").Include(
                "~/Content/js/custom.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/deznav-init/js").Include(
                "~/Content/js/deznav-init.js"));
            bundles.Add(new ScriptBundle("~/bundles/Chart.bundle.min/js").Include(
                "~/Content/vendor/chart.js/Chart.bundle.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/owl.carousel/js").Include(
                "~/Content/vendor/owl-carousel/owl.carousel.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.peity/js").Include(
                "~/Content/vendor/peity/jquery.peity.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/apexchart/js").Include(
               "~/Content/vendor/apexchart/apexchart.js"));
            bundles.Add(new ScriptBundle("~/bundles/dashboard-1/js").Include(
              "~/Content/js/dashboard/dashboard-1.js"));
            









        }
    }
}