using System;

namespace program1.library.Module
{
	public class Module
	{
		public string? Name { get; set; }
		public string? Description { get; set; }
		public List<ContentItem> Content { get; set; }

		public Module()
		{
			Content = new List<ContentItem>();
		}
	}
}

