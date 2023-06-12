using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PhotoEnhancer
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();

            mainForm.AddFilter(new PixelFilter<LighteningParameters>(
                "Осветление/затемнение",
                (pixel, parameters) => pixel * parameters.Coefficient));

            Random rnd = new Random();
            mainForm.AddFilter(new PixelFilter<NoiseParameters>(
                "Уровень шума",
                (pixel, parameters) => new Pixel(
                    (parameters.Coefficient * rnd.NextDouble() + (1 - parameters.Coefficient) * pixel.R),
                    (parameters.Coefficient * rnd.NextDouble() + (1 - parameters.Coefficient) * pixel.G),
                    (parameters.Coefficient * rnd.NextDouble() + (1 - parameters.Coefficient) * pixel.B)
                    )));

            mainForm.AddFilter(new PixelFilter<EmptyParameters>(
                "Оттенки серого",
                (pixel, parameters) =>
                {
                    var lightness = 0.3 * pixel.R + 0.6 * pixel.G + 0.1 * pixel.B;
                    return new Pixel(lightness, lightness, lightness);
                }));

            mainForm.AddFilter(new TransformFilter(
                "Отражение по горизонтали",
                size => size,
                (point, size) => new Point(size.Width - point.X - 1, point.Y)
                ));

            mainForm.AddFilter(new TransformFilter(
                "Устранение черезстрочной развертки",
                size => size,
                (point, size) => new Point(point.X, point.Y - (point.Y%2))
                ));

            mainForm.AddFilter(new TransformFilter(
                "Поворот на 90° против ч. с.",
                size => new Size(size.Height, size.Width),
                (point, size) => new Point(size.Width - point.Y - 1, point.X)
                ));

            mainForm.AddFilter(new TransformFilter<RotationParameters>(
                "Поворот на произвольный угол",
                new RotateTransformer()
                ));

            mainForm.AddFilter(new TransformFilter<Task4Parameters>(
                "Сдвиг влево",
                new Task4Transformer()
                ));

            Application.Run(mainForm);
        }
    }
}
