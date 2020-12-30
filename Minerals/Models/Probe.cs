namespace Minerals.Models {
    public class Probe {
        [ExcelCol("ID")] public string Id { get; set; }

        [ExcelCol("Identifikation")]
        public string Serial { get; set; }

        [ExcelCol("Mineral")]
        public string Mineral { get; set; }

        [ExcelCol(new[] {"FundortZeile1", "FundortZeile2", "FundortZeile3"})]
        public string Location { get; set; }

        [ExcelCol("Datum")]
        public string TimeStamp { get; set; }

        [ExcelCol("Wert")]
        public string Value { get; set; }

        [ExcelCol("woher")]
        public string Origin { get; set; }

        [ExcelCol("Größe")]
        public string Size { get; set; }

        [ExcelCol("Bemerkung")]
        public string Annotation { get; set; }

        [ExcelCol("Gedruckt")]
        public string Printed { get; set; }

        [ExcelCol("Begleitmineral")]
        public string SideMineral { get; set; }

        public string ImageName { get; set; }
        public string SampleNumber { get; set; }
        public string Analytics { get; set; }
    }
}
