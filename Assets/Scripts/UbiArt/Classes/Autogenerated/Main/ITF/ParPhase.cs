using UnityEngine;

namespace UbiArt.ITF {
	public partial class ParPhase : CSerializable {
		[Serialize("phaseTime"       )] public float phaseTime;
		[Serialize("colorMin"        )] public Color colorMin;
		[Serialize("colorMax"        )] public Color colorMax;
		[Serialize("sizeMin"         )] public Vector2 sizeMin;
		[Serialize("sizeMax"         )] public Vector2 sizeMax;
		[Serialize("animstart"       )] public int animstart;
		[Serialize("animend"         )] public int animend;
		[Serialize("animname"        )] public StringID animname;
		[Serialize("deltaphasetime"  )] public float deltaphasetime;
		[Serialize("animstretchtime" )] public bool animstretchtime;
		[Serialize("blendtonextphase")] public bool blendtonextphase;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(phaseTime));
			SerializeField(s, nameof(colorMin));
			SerializeField(s, nameof(colorMax));
			SerializeField(s, nameof(sizeMin));
			SerializeField(s, nameof(sizeMax));
			SerializeField(s, nameof(animstart));
			SerializeField(s, nameof(animend));
			SerializeField(s, nameof(animname));
			SerializeField(s, nameof(deltaphasetime));
			SerializeField(s, nameof(animstretchtime));
			SerializeField(s, nameof(blendtonextphase));
		}
	}
}

