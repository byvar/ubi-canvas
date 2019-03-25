using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class AFX_GlowParam : CSerializable {
		[Serialize("use"            )] public bool use;
		[Serialize("factor"         )] public float factor;
		[Serialize("blurSize"       )] public float blurSize;
		[Serialize("bigBlur"        )] public bool bigBlur;
		[Serialize("threshold"      )] public float threshold;
		[Serialize("thresholdSmooth")] public float thresholdSmooth;		
		[Serialize("pixelSize"     )] public uint pixelSize;
		[Serialize("quality"       )] public uint quality;
		[Serialize("useToneMap"    )] public bool useToneMap;
		[Serialize("thresholdScale")] public float thresholdScale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.RL) {
				if (Settings.s.game == Settings.Game.COL) {
					SerializeField(s, nameof(use), boolAsByte: true);
				} else {
					SerializeField(s, nameof(use));
				}
				SerializeField(s, nameof(factor));
				SerializeField(s, nameof(pixelSize));
				SerializeField(s, nameof(quality));
				SerializeField(s, nameof(useToneMap));
				SerializeField(s, nameof(threshold));
				SerializeField(s, nameof(thresholdScale));
			} else {
				SerializeField(s, nameof(use));
				SerializeField(s, nameof(factor));
				SerializeField(s, nameof(blurSize));
				SerializeField(s, nameof(bigBlur));
				SerializeField(s, nameof(threshold));
				SerializeField(s, nameof(thresholdSmooth));
			}
		}
	}
}

