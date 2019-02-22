using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	[AttributeUsage(AttributeTargets.Field)]
	public class SerializeAttribute : System.Attribute {
		private int order;
		private string name;
		public Settings.EngineVersion version = Settings.EngineVersion.None;
		public Settings.Game game = Settings.Game.None;
		public Settings.Platform platform = Settings.Platform.None;

		public SerializeAttribute(int order, string name) {
			this.order = order;
			this.name = name;
		}

		public int Order => order;
	}
}
