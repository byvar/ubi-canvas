using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_BlurParam : BaseObject {
		[Serialize(0, "use")]                                public bool use;
		[Serialize(1, "pixelSize", game = Settings.Game.RL)] public uint pixelSize;
		[Serialize(2, "quality",   game = Settings.Game.RL)] public uint quality;

		[Serialize(1, "pixelSize", game = Settings.Game.RA)] public float pixelSizeAdventures;
		[Serialize(2, "bigBlur",   game = Settings.Game.RA)] public bool bigBlur;


		public AFX_BlurParam(Reader reader) : base(reader) {
			use = reader.ReadBoolean();
			pixelSize = reader.ReadUInt32();
			quality = reader.ReadUInt32();
		}
	}
}
