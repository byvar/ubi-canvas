using UbiCanvas;
using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UbiCanvas.Helpers {
    public static class Util {
        public static bool ByteArrayToFile(string fileName, byte[] byteArray) {
            if (byteArray == null)
                return false;

            if (FileSystem.mode == FileSystem.Mode.Web)
                return false;

            try {
                Directory.CreateDirectory(Path.GetDirectoryName(fileName));

                using var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                fs.Write(byteArray, 0, byteArray.Length);
                return true;
            } catch (Exception ex) {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }
        }

        private static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        public static string SizeSuffix(long value, int decimalPlaces = 1) {
            if (value < 0)
                return "-" + SizeSuffix(-value);

            int i = 0;
            decimal dValue = value;
            while (Math.Round(dValue, decimalPlaces) >= 1000) {
                dValue /= 1024;
                i++;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}", dValue, SizeSuffixes[i]);
        }

        public static uint NextPowerOfTwo(uint v) {
            v--;
            v |= v >> 1;
            v |= v >> 2;
            v |= v >> 4;
            v |= v >> 8;
            v |= v >> 16;
            v++;
            return v;
        }

        public static string NormalizePath(string path, bool isFolder) {
            string newPath = path.Replace("\\", "/");

            if (isFolder && !newPath.EndsWith("/"))
                newPath += "/";

            return newPath;
        }

        public static void CopyDir(string inputDir, string outputDir) {
            foreach (string dirPath in Directory.GetDirectories(inputDir, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(inputDir, outputDir));

            foreach (string newPath in Directory.GetFiles(inputDir, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(inputDir, outputDir), true);
        }

        public static void RenameFilesToUpper(string inputDir) {
            foreach (var file in Directory.GetFiles(inputDir, "*", SearchOption.AllDirectories)) {
                var dir = Path.GetDirectoryName(file);
                var fileName = Path.GetFileName(file);

                // Move to temp name
                var tempPath = Path.Combine(dir, $"TEMP_{fileName}");
                File.Move(file, tempPath);

                // Move to upper-case name
                File.Move(tempPath, Path.Combine(dir, fileName.ToUpper()));
            }
        }

        public static void FindMatchingEncoding(params KeyValuePair<string, byte[]>[] input) {
            if (input.Length < 2)
                throw new Exception("Too few strings to check!");

            // Get all possible encodings
            var encodings = Encoding.GetEncodings().Select(x => Encoding.GetEncoding(x.CodePage)).ToArray();

            // Keep a list of all matching ones
            var matches = new List<Encoding>();

            // Helper method for getting all matching encodings
            IEnumerable<Encoding> GetMatches(KeyValuePair<string, byte[]> str) {
                var m = encodings.Where(enc => enc.GetString(str.Value).Equals(str.Key, StringComparison.InvariantCultureIgnoreCase)).ToArray();
                Debug.Log($"Matching encodings for {str.Key}: {String.Join(", ", m.Select(x => $"{x.EncodingName} ({x.CodePage})"))}");
                return m;
            }

            // Add matches for the first one
            matches.AddRange(GetMatches(input.First()));

            // Check remaining ones, removing any which don't match
            foreach (var str in input.Skip(1)) {
                var ma = GetMatches(str);
                matches.RemoveAll(x => !ma.Contains(x));
            }

            // Log the result
            Debug.Log($"Matching encodings for all: {String.Join(", ", matches.Select(x => $"{x.EncodingName} ({x.CodePage})"))}");
        }

        public static int GCF(int[] values) {
            return values.Aggregate(GCF);
        }

        public static int GCF(int a, int b) {
            while (b != 0) {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int LCM(int a, int b) {
            return (a / GCF(a, b)) * b;
        }

        public static int LCM(IList<int> numbers, int i = 0) {
            if (i + 2 == numbers.Count)
                return LCM(numbers[i], numbers[i + 1]);
            else
                return LCM(numbers[i], LCM(numbers, i + 1));
        }

        public static IEnumerable<T[]> Split<T>(this T[] array, int length, int size) => Enumerable.Range(0, length).Select(x => array.Skip(size * x).Take(size).ToArray());

        public enum TileEncoding {
            Planar_2bpp,
            Planar_4bpp,
            Linear_4bpp,
            Linear_4bpp_ReverseOrder,
            Linear_8bpp,
			Linear_8bpp_A3i5,
			Linear_8bpp_A5i3,
            Linear_32bpp_RGBA,
            Linear_32bpp_BGRA,
            Linear_16bpp_4444_ABGR,
        }

    }
}