using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_GlowParam : BaseObject {
		[Serialize(0, "use")] public bool use;
		[Serialize(1, "factor")] public float factor;
		[Serialize(2, "blurSize", game = Settings.Game.RA)] public float blurSize;
		[Serialize(3, "bigBlur", game = Settings.Game.RA)] public bool bigBlur;
		[Serialize(4, "pixelSize", game = Settings.Game.RL)] public uint pixelSize;
		[Serialize(5, "quality", game = Settings.Game.RL)] public uint quality;
		[Serialize(6, "useToneMap", game = Settings.Game.RL)] public bool useToneMap;
		[Serialize(7, "threshold")] public float threshold;
		[Serialize(8, "thresholdSmooth", game = Settings.Game.RA)] public float thresholdSmooth;
		[Serialize(9, "thresholdScale", game = Settings.Game.RL)] public float thresholdScale;


		public AFX_GlowParam(Reader reader) : base(reader) {
		}
	}
}
