using UnityEngine;

namespace UbiArt.ITF {
	public partial class EdgeData : CSerializable {
		[Serialize("Level"           )] public float Level;
		[Serialize("Pos"             )] public float Pos;
		[Serialize("Way"             )] public int Way;
		[Serialize("CutUV"           )] public bool CutUV;
		[Serialize("HeightScale"     )] public float HeightScale;
		[Serialize("HeightScaleTotal")] public float HeightScaleTotal;
		[Serialize("HeightPos"       )] public float HeightPos;
		[Serialize("PosZ"            )] public float PosZ;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Level));
			SerializeField(s, nameof(Pos));
			SerializeField(s, nameof(Way));
			SerializeField(s, nameof(CutUV));
			SerializeField(s, nameof(HeightScale));
			SerializeField(s, nameof(HeightScaleTotal));
			SerializeField(s, nameof(HeightPos));
			SerializeField(s, nameof(PosZ));
		}
	}
}

