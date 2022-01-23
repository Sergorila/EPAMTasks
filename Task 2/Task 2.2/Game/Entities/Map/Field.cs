using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities.Map.Cells;

namespace Game.Entities
{
    public class Field
    {
        private static int _width;
        private static int _height;
        public Material[][] Map { get; }

        public static int Width => _width;
        public static int Height => _height;

        public Material GetCellType(Cell cell)
        {
            return Map[cell.X][cell.Y];
        }

        public Field(int width, int height)
        {
            _width = width;
            _height = height;
            Map = new Material[height][];
            for (int i = 0; i < width; i++)
            {
                Map[i] = new Material[width];
            }
        }

        private Material RandomCell()
        {
            Random r = new Random();
            Type baseType = typeof(Material);
            var allDerivedTypes = baseType.Assembly.ExportedTypes.Where(t => baseType.IsAssignableFrom(t)).Where(t => t.IsAbstract == false).ToArray();

            Material mat = Activator.CreateInstance(Type.GetType(allDerivedTypes[r.Next(0, allDerivedTypes.Length)].FullName)) as Material;
            return mat;
        }

        private void SetRandomField(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Map[i][j] = RandomCell();
                }
            }
        }
    }
}
