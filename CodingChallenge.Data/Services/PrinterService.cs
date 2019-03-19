using CodingChallenge.Data.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Services
{
    public static class PrinterService
    {
        public static string Imprimir(List<FormaGeometrica> formas)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(TranslatorService.Translate("EmptyList"));
            }
            else
            {
                sb.Append(TranslatorService.Translate("ReportTitle"));

                var groups = formas.GroupBy(x => x.GetType()).ToList();
                foreach (var g in groups)
                {
                    sb.Append(GetLinea(g.ToList()));
                }

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(TranslatorService.Translate("ShapesQuantity", new[] { formas.Count.ToString() }));
                sb.Append(" ");
                sb.Append(TranslatorService.Translate("PerimeterTotal", new[] { formas.Sum(f => f.Perimetro).ToString("#.##") }));
                sb.Append(" ");
                sb.Append(TranslatorService.Translate("AreaTotal", new[] { formas.Sum(f => f.Area).ToString("#.##") }));
            }

            return sb.ToString();
        }

        private static string GetLinea(List<FormaGeometrica> formas)
        {
            int cantidad = formas.Count;
            string forma = TranslatorService.Pluralize(formas.FirstOrDefault().GetType().Name, cantidad);
            return TranslatorService.Translate("ShapeDetail", cantidad, forma, formas.Sum(f => f.Area).ToString("#.##"), formas.Sum(f => f.Perimetro).ToString("#.##"));
        }
    }
}
