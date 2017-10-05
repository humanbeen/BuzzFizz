namespace BuzzFizz.Formatters
{
    using System.Linq;

    using Constants;

    public class ThreeAndFiveDigitFormater : IDigitFormater
    {
        public string Format(long value)
        {
            var mulitpliers = ValueProvidersConstants.ThreeAndFiveReplacement.Where(it => value % it.Key == 0).Select(it => it.Value).ToList();

            if (mulitpliers.Any())
            {
                return string.Join("", mulitpliers);
            }

            return value.ToString();
        }
    }
}