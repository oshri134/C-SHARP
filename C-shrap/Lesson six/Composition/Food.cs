using System;

namespace Lesson06
{
    class Food
    {
		// properties:
		private string foodName;
		public string FoodName
		{
			get { return foodName; }
			set { foodName = value; }
		}

		// Composition: class food has a property type of other class: 
		private ExDate expirationDate;
		public ExDate ExpirationDate
		{
			get { return expirationDate; }
			set { expirationDate = value; }
		}

		// methods:
		public override string ToString()
		{
			return $"food name: {foodName}";
		}
	}
}
