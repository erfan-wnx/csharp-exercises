
using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

// Student class
public class Student
{
    public string Name { get; set; } = "";
    public int StudentId { get; set; }
    public string Major { get; set; } = "";

    public Student()
    {
    }
}

class Program
{
    static void Main()
    {
        // Create a Student object
        Student student = new Student
        {
            Name = "erfan",
            StudentId = 101,
            Major = "multimedia"
        };

        // Convert Student object to JSON
        string json = JsonSerializer.Serialize(
            student,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        Console.WriteLine("JSON Output:");
        Console.WriteLine(json);

        // Convert Student object to XML
        XmlSerializer serializer =
            new XmlSerializer(typeof(Student));

        using StringWriter writer = new StringWriter();
        serializer.Serialize(writer, student);

        string xml = writer.ToString();

        Console.WriteLine();
        Console.WriteLine("XML Output:");
        Console.WriteLine(xml);
    }
}
