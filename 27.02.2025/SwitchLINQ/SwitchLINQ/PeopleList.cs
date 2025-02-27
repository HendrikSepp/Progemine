namespace PeopleList
{
	public class PeopleList
	{
		public static readonly List<People> peoples = new List<People>
		{
			new People()
			{
				Id = 1,
				Name = "Joonas",
				Age = 33,
				GenderId Guid.Parse("e195e7fd-0e46-440c-b315-cfcd2047b712")
			},
            new People()
            {
                Id = 2,
                Name = "Moona",
                Age = 18,
                GenderId Guid.Parse("685798c0-a1a0-4246-80e1-4f1fd7f79d54")
            },
            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 21,
                GenderId Guid.Parse("e195e7fd-0e46-440c-b315-cfcd2047b712")
            },            
            new People()
            {
                Id = 4,
                Name = "Mary",
                Age = 20,
                GenderId Guid.Parse("685798c0-a1a0-4246-80e1-4f1fd7f79d54")
            },            
            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 17,
                GenderId Guid.Parse("685798c0-a1a0-4246-80e1-4f1fd7f79d54")
            },            
            new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 19,
                GenderId Guid.Parse("685798c0-a1a0-4246-80e1-4f1fd7f79d54")
            }
        };
	}
}
