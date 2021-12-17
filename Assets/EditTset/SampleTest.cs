using System.IO;
using System.Text;
using NUnit.Framework;
using UnityEngine;
using YamlDotNet.RepresentationModel;

namespace Sample
{
    public class SampleTest
    {
        [Test]
public void ParseTest()
{
    // setup
    var text = @"
numbers:
  - 1
  - 2
  - 3
HP: 100
MP: 10
SP: 32
";
    var yamlPath = "/tmp/sample.yml";
    File.WriteAllText(yamlPath, text);

    // read
    var reader = new StreamReader(yamlPath, Encoding.UTF8);
    var yaml = new YamlStream();
    yaml.Load(reader);

    var numbersNode = yaml.Documents[0].RootNode["numbers"];
    Debug.Log(numbersNode); // Output: [ 1, 2, 3 ]
    
    var hpNode = yaml.Documents[0].RootNode["HP"];
    Debug.Log(hpNode); // Output: 100
    var mpNode = yaml.Documents[0].RootNode["MP"];
    Debug.Log(mpNode); // Output: 10
    var spNode = yaml.Documents[0].RootNode["SP"];
    Debug.Log(spNode); // Output: 32
}
    }
}