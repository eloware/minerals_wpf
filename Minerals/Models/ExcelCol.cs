using System;

namespace Minerals.Models {
    public class ExcelCol : Attribute {
        public string[] Names { get; }

        public ExcelCol(string[] names) {
            Names = names;
        }

        public ExcelCol(string name) {
            Names = new[] {name};
        }
    }
}
