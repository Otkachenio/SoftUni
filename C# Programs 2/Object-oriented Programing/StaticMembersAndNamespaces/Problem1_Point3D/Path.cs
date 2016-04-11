using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Problem1_Point3D
{
    public class Path
    {
        private List<Point3D> points = new List<Point3D>();

        public Path(params Point3D[] points)
        {
            this.points = new List<Point3D>();
            this.points.AddRange(points);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Path { ");
            result.Append(string.Join(",", this.points));
            result.Append("}");

            return result.ToString();
        }

        public void WriteToFile(string path)
        {
            File.WriteAllText(path, this.ToString());
        }

        public static Path ReadFromFile(string fileName)
        {
            string pathStr = File.ReadAllText(fileName);
            Regex regex = new Regex(".*?X=(.*?), Y=(.*?), Z=(.*?)\\)");
            var maches = regex.Matches(pathStr);
            Path path = new Path();

            for (int i = 0; i < maches.Count; i++)
            {
                double x = double.Parse(maches[i].Groups[1].Value);
                double y = double.Parse(maches[i].Groups[1].Value);
                double z = double.Parse(maches[i].Groups[1].Value);
                Point3D point = new Point3D(x, y, z);
                path.points.Add(point);
            }

            return path;
        }
    }
}