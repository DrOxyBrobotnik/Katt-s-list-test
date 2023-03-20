using ArrayListAssignment;

namespace AssignmentTests
{
    public class Tests
    {
        [Test]
        public void Empty_Constructor_Should_Create_Empty_ArrayList()
        {
            var array = new KittyArrayList();

            Assert.That(array, Has.Length.EqualTo(0));
        }

        [Test]
        public void Get_Outside_Of_Bounds_Should_Throw()
        {
            var array = new KittyArrayList();

            Assert.That(() => array.Get(int.MaxValue), Throws.Exception);
        }

        [Test]
        public void Add_Should_Store_Value()
        {
            var array = new KittyArrayList();

            array.Add(62345);

            Assert.That(array.Get(0), Is.EqualTo(62345));
        }

        [Test]
        public void Add_Should_Store_Multiple_Values()
        {
            var array = new KittyArrayList();
            var rand = new Random();

            for (var i = 0; i < 100; i++)
            {
                var value = rand.Next(int.MaxValue);
                array.Add(value);

                Assert.That(array.Get(i), Is.EqualTo(value));
            }
        }

        [Test]
        public void Add_Should_Increment_Length()
        {
            var array = GetRandomizedArray(123);

            Assert.That(array, Has.Length.EqualTo(123));
        }

        [Test]
        public void Remove_Should_Remove_And_Shift_Values()
        {
            var array = new KittyArrayList();

            array.Add(5);
            array.Add(8);
            array.Add(8);
            array.Add(2);

            array.Remove(8);

            Assert.That(array.Get(1), Is.EqualTo(2));
        }

        [Test]
        public void Remove_Should_Decrement_Length()
        {
            var array = new KittyArrayList();

            array.Add(5);
            array.Add(8);
            array.Add(8);
            array.Add(2);

            array.Remove(8);

            Assert.That(array, Has.Length.EqualTo(2));
        }

        private static KittyArrayList GetRandomizedArray(int length)
        {
            var array = new KittyArrayList();
            var rand = new Random();

            for (var i = 0; i < length; i++)
            {
                array.Add(rand.Next(int.MaxValue));
            }

            return array;
        }
    }
}