using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleLibrary;

namespace TriangleLibraryTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void DetermineTriangleType_InvalidSides_ReturnsInvalidSides()
        {
            string result = Triangle.DetermineTriangleType(-2, 4, 5);
            Assert.AreEqual("Неверные длины сторон", result);
        }

        [TestMethod]
        public void DetermineTriangleType_InvalidSidesWithZero_ReturnsInvalidSides()
        {
            string result = Triangle.DetermineTriangleType(3, 0, 6);
            Assert.AreEqual("Неверные длины сторон", result);
        }

        [TestMethod]
        public void DetermineTriangleType_NonExistentTriangle_ReturnsNonExistentTriangle()
        {
            string result = Triangle.DetermineTriangleType(1, 2, 3);
            Assert.AreEqual("Треугольник не существует", result);
        }

        [TestMethod]
        public void DetermineTriangleType_EquilateralTriangle_ReturnsEquilateralTriangle()
        {
            string result = Triangle.DetermineTriangleType(4, 4, 4);
            Assert.AreEqual("Остроугольный треугольник", result);
        }

        [TestMethod]
        public void DetermineTriangleType_IsoscelesRightTriangle_ReturnsIsoscelesRightTriangle()
        {
            string result = Triangle.DetermineTriangleType(3, 4, 5);
            Assert.AreEqual("Прямоугольный треугольник", result);
        }

        [TestMethod]
        public void DetermineTriangleType_ObtuseTriangle_ReturnsObtuseTriangle()
        {
            string result = Triangle.DetermineTriangleType(17, 18, 25);
            Assert.AreEqual("Тупоугольный треугольник", result);
        }

        [TestMethod]
        public void DetermineTriangleType_ScaleneAcuteTriangle_ReturnsScaleneAcuteTriangle()
        {
            string result = Triangle.DetermineTriangleType(3, 5, 5);
            Assert.AreEqual("Остроугольный треугольник", result);
        }
    }
}
