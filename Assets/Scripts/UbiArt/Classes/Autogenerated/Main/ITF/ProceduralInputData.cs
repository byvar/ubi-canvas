using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class ProceduralInputData : CSerializable {
		[Serialize("input"       )] public StringID input;
		[Serialize("min"         )] public float min;
		[Serialize("max"         )] public float max;
		[Serialize("initialValue")] public float initialValue;
		[Serialize("minValue"    )] public float minValue;
		[Serialize("maxValue"    )] public float maxValue;
		[Serialize("mod"         )] public bool mod;
		[Serialize("abs"         )] public bool abs;
		[Serialize("add"         )] public bool add;
		[Serialize("sin"         )] public bool sin;
		[Serialize("curve"       )] public Spline curve;
		[Serialize("StringID__0" )] public StringID StringID__0;
		[Serialize("float__1"    )] public float float__1;
		[Serialize("float__2"    )] public float float__2;
		[Serialize("float__3"    )] public float float__3;
		[Serialize("float__4"    )] public float float__4;
		[Serialize("int__5"      )] public int int__5;
		[Serialize("int__6"      )] public int int__6;
		[Serialize("int__7"      )] public int int__7;
		[Serialize("StringID__8" )] public StringID StringID__8;
		[Serialize("float__9"    )] public float float__9;
		[Serialize("float__10"   )] public float float__10;
		[Serialize("float__11"   )] public float float__11;
		[Serialize("float__12"   )] public float float__12;
		[Serialize("bool__13"    )] public bool bool__13;
		[Serialize("bool__14"    )] public bool bool__14;
		[Serialize("bool__15"    )] public bool bool__15;
		[Serialize("bool__16"    )] public bool bool__16;
		[Serialize("Spline__17"  )] public Spline Spline__17;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(int__5));
				SerializeField(s, nameof(int__6));
				SerializeField(s, nameof(int__7));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(StringID__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(float__10));
				SerializeField(s, nameof(float__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(bool__13));
				SerializeField(s, nameof(bool__14));
				SerializeField(s, nameof(bool__15));
				SerializeField(s, nameof(bool__16));
				SerializeField(s, nameof(Spline__17));
			} else {
				SerializeField(s, nameof(input));
				SerializeField(s, nameof(min));
				SerializeField(s, nameof(max));
				SerializeField(s, nameof(initialValue));
				SerializeField(s, nameof(minValue));
				SerializeField(s, nameof(maxValue));
				SerializeField(s, nameof(mod));
				SerializeField(s, nameof(abs));
				SerializeField(s, nameof(add));
				SerializeField(s, nameof(sin));
				SerializeField(s, nameof(curve));
			}
		}
	}
}

