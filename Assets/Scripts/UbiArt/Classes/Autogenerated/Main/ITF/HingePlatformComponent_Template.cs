using UnityEngine;

namespace UbiArt.ITF {
	public partial class HingePlatformComponent_Template : PolylineComponent_Template {
		[Serialize("hingeBones"     )] public CList<HingePlatformComponent_Template.HingeBoneData> hingeBones;
		[Serialize("platforms"      )] public CList<HingePlatformComponent_Template.PlatformData> platforms;
		[Serialize("movingPolylines")] public CList<HingePlatformComponent_Template.MovingPolylineData> movingPolylines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hingeBones));
			SerializeField(s, nameof(platforms));
			SerializeField(s, nameof(movingPolylines));
		}
		public partial class MovingPolylineData : CSerializable {
			[Serialize("polyline"       )] public StringID polyline;
			[Serialize("resistance"     )] public float resistance;
			[Serialize("forceMultiplier")] public float forceMultiplier;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(polyline));
				SerializeField(s, nameof(resistance));
				SerializeField(s, nameof(forceMultiplier));
			}
		}
		public partial class HingeBoneData : CSerializable {
			[Serialize("name"                         )] public StringID name;
			[Serialize("polyline"                     )] public StringID polyline;
			[Serialize("minAngle"                     )] public Angle minAngle;
			[Serialize("maxAngle"                     )] public Angle maxAngle;
			[Serialize("weight"                       )] public float weight;
			[Serialize("resistance"                   )] public float resistance;
			[Serialize("hitForce"                     )] public float hitForce;
			[Serialize("windMultiplier"               )] public float windMultiplier;
			[Serialize("weightMultiplier"             )] public float weightMultiplier;
			[Serialize("branchStiff"                  )] public float branchStiff;
			[Serialize("branchDamping"                )] public float branchDamping;
			[Serialize("branchDelayMultiplier"        )] public float branchDelayMultiplier;
			[Serialize("disableScale"                 )] public bool disableScale;
			[Serialize("disableCollision"             )] public bool disableCollision;
			[Serialize("useDynamicBranchStiff"        )] public bool useDynamicBranchStiff;
			[Serialize("dynamicBranchStiffMinAngle"   )] public Angle dynamicBranchStiffMinAngle;
			[Serialize("dynamicBranchStiffMaxAngle"   )] public Angle dynamicBranchStiffMaxAngle;
			[Serialize("dynamicBranchStiffMultiplier" )] public float dynamicBranchStiffMultiplier;
			[Serialize("dynamicBranchStiffOnlyWayBack")] public bool dynamicBranchStiffOnlyWayBack;
			[Serialize("alwaysApplyAngleLimitation"   )] public bool alwaysApplyAngleLimitation;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(polyline));
				SerializeField(s, nameof(minAngle));
				SerializeField(s, nameof(maxAngle));
				SerializeField(s, nameof(weight));
				SerializeField(s, nameof(resistance));
				SerializeField(s, nameof(hitForce));
				SerializeField(s, nameof(windMultiplier));
				SerializeField(s, nameof(weightMultiplier));
				SerializeField(s, nameof(branchStiff));
				SerializeField(s, nameof(branchDamping));
				SerializeField(s, nameof(branchDelayMultiplier));
				SerializeField(s, nameof(disableScale));
				SerializeField(s, nameof(disableCollision));
				SerializeField(s, nameof(useDynamicBranchStiff));
				SerializeField(s, nameof(dynamicBranchStiffMinAngle));
				SerializeField(s, nameof(dynamicBranchStiffMaxAngle));
				SerializeField(s, nameof(dynamicBranchStiffMultiplier));
				SerializeField(s, nameof(dynamicBranchStiffOnlyWayBack));
				SerializeField(s, nameof(alwaysApplyAngleLimitation));
			}
		}
		public partial class PlatformData : CSerializable {
			[Serialize("poly"              )] public StringID poly;
			[Serialize("scale"             )] public StringID scale;
			[Serialize("link"              )] public StringID link;
			[Serialize("maxPitch"          )] public Angle maxPitch;
			[Serialize("minWeight"         )] public float minWeight;
			[Serialize("minWeightScale"    )] public float minWeightScale;
			[Serialize("maxWeight"         )] public float maxWeight;
			[Serialize("maxWeightScale"    )] public float maxWeightScale;
			[Serialize("MinScale"          )] public float MinScale;
			[Serialize("scaleStiff"        )] public float scaleStiff;
			[Serialize("scaleDamping"      )] public float scaleDamping;
			[Serialize("minWeightHinge"    )] public float minWeightHinge;
			[Serialize("disableCollision"  )] public bool disableCollision;
			[Serialize("hitForceMultiplier")] public float hitForceMultiplier;
			[Serialize("onlyCrushAttack"   )] public bool onlyCrushAttack;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(poly));
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(link));
				SerializeField(s, nameof(maxPitch));
				SerializeField(s, nameof(minWeight));
				SerializeField(s, nameof(minWeightScale));
				SerializeField(s, nameof(maxWeight));
				SerializeField(s, nameof(maxWeightScale));
				SerializeField(s, nameof(MinScale));
				SerializeField(s, nameof(scaleStiff));
				SerializeField(s, nameof(scaleDamping));
				SerializeField(s, nameof(minWeightHinge));
				SerializeField(s, nameof(disableCollision));
				SerializeField(s, nameof(hitForceMultiplier));
				SerializeField(s, nameof(onlyCrushAttack));
			}
		}
		public override uint? ClassCRC => 0x0B2FF7DB;
	}
}

