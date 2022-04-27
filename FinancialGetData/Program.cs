using System.Xml.Linq;

var fileName = @"file_with_Path.trx";

var xdoc = XDocument.Load(fileName);

XNamespace ns = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010";

//var unitTestNode = (from data in xdoc.Descendants(ns + "TestDefinitions")
//                    select data).Descendants(ns + "UnitTest").ToList();

var unitTestNode = (from data in xdoc.Descendants(ns + "UnitTest")
                    select data).ToList();

var recordSet = (from src in unitTestNode
                 select new
                 {
                     TestName = src.Attribute("name")?.Value,
                     TestCategory = (from data in src.Descendants(ns + "TestCategoryItem") select data)
                                    .FirstOrDefault()?.Attribute("TestCategory")?.Value,
                 });


foreach(var i in recordSet)
{
    Console.WriteLine($"test: {i.TestName}, category: {i.TestCategory}");
}
