using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AFX_GlowParam : CSerializable {
		[Serialize("use"            )] public bool use;
		[Serialize("factor"         )] public float factor;
		[Serialize("blurSize"       )] public float blurSize;
		[Serialize("bigBlur"        )] public bool bigBlur;
		[Serialize("threshold"      )] public float threshold;
		[Serialize("thresholdSmooth")] public float thresholdSmooth;
		[Serialize("bool__0"        )] public bool bool__0;
		[Serialize("float__1"       )] public float float__1;
		[Serialize("uint__2"        )] public uint uint__2;
		[Serialize("uint__3"        )] public uint uint__3;
		[Serialize("bool__4"        )] public bool bool__4;
		[Serialize("float__5"       )] public float float__5;
		[Serialize("float__6"       )] public float float__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(bool__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(uint__2));
				SerializeField(s, nameof(uint__3));
				SerializeField(s, nameof(bool__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
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

