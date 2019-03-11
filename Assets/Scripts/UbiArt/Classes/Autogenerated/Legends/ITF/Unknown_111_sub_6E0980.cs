using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_111_sub_6E0980 : CSerializable {
		[Serialize("LookAtDist"         )] public float LookAtDist;
		[Serialize("MaxLookAtModule"    )] public uint MaxLookAtModule;
		[Serialize("CheckAttackDistance")] public float CheckAttackDistance;
		[Serialize("AttackDistance"     )] public float AttackDistance;
		[Serialize("PolylineDepthOffset")] public float PolylineDepthOffset;
		[Serialize("TailBone"           )] public StringID TailBone;
		[Serialize("HeadBone"           )] public StringID HeadBone;
		[Serialize("DrawDebugHit"       )] public bool DrawDebugHit;
		[Serialize("PropagationTimer"   )] public float PropagationTimer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LookAtDist));
			SerializeField(s, nameof(MaxLookAtModule));
			SerializeField(s, nameof(CheckAttackDistance));
			SerializeField(s, nameof(AttackDistance));
			SerializeField(s, nameof(PolylineDepthOffset));
			SerializeField(s, nameof(TailBone));
			SerializeField(s, nameof(HeadBone));
			SerializeField(s, nameof(DrawDebugHit));
			SerializeField(s, nameof(PropagationTimer));
		}
		public override uint? ClassCRC => 0x2DEB7659;
	}
}

