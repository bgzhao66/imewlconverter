/*
 *   Copyright © 2009-2020 studyzy(深蓝,曾毅)

 *   This program "IME WL Converter(深蓝词库转换)" is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.

 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.

 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using System.Linq;
using NUnit.Framework;
using Studyzy.IMEWLConverter.Generaters;

namespace Studyzy.IMEWLConverter.Test.GeneraterTest
{
    [TestFixture]
    class CangjieTest
    {
        private IWordCodeGenerater generater;

        [OneTimeSetUp]
        public void SetUp()
        {
            generater = new Cangjie5Generater();
        }

        [Test]
        public void TestGetOneWordCangjie() { }

        [TestCase("曾毅", "cayoe")]
        [TestCase("音乐", "yahvd")]
        [TestCase("快乐", "pkhvd")]
        [TestCase("银行", "ovhon")]
        [TestCase("行走", "hngyo")]
        [TestCase("处理", "hymgg")]
        [TestCase("处理", "homgg")]
        public void TestGetLongWordsCangjie(string str, string py)
        {
            var result = generater.GetCodeOfString(str);
            Assert.Contains(py, result.ToCodeString(" ").ToArray());
        }
    }
}
