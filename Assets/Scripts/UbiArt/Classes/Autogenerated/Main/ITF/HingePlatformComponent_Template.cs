using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class HingePlatformComponent_Template : PolylineComponent_Template {
		public CListO<HingePlatformComponent_Template.HingeBoneData> hingeBones;
		public CListO<HingePlatformComponent_Template.PlatformData> platforms;
		public CListO<HingePlatformComponent_Template.MovingPolylineData> movingPolylines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hingeBones = s.SerializeObject<CListO<HingePlatformComponent_Template.HingeBoneData>>(hingeBones, name: "hingeBones");
			platforms = s.SerializeObject<CListO<HingePlatformComponent_Template.PlatformData>>(platforms, name: "platforms");
			movingPolylines = s.SerializeObject<CListO<HingePlatformComponent_Template.MovingPolylineData>>(movingPolylines, name: "movingPolylines");
		}
		[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
		public partial class MovingPolylineData : CSerializable {
			public StringID polyline;
			public float resistance;
			public float forceMultiplier;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				polyline = s.SerializeObject<StringID>(polyline, name: "polyline");
				resistance = s.Serialize<float>(resistance, name: "resistance");
				forceMultiplier = s.Serialize<float>(forceMultiplier, name: "forceMultiplier");
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
		public partial class HingeBoneData : CSerializable {
			public StringID name;
			public StringID polyline;
			public Angle minAngle;
			public Angle maxAngle;
			public float weight;
			public float resistance;
			public float hitForce;
			public float windMultiplier;
			public float weightMultiplier;
			public float branchStiff;
			public float branchDamping;
			public float branchDelayMultiplier;
			public bool disableScale;
			public bool disableCollision;
			public bool useDynamicBranchStiff;
			public Angle dynamicBranchStiffMinAngle;
			public Angle dynamicBranchStiffMaxAngle;
			public float dynamicBranchStiffMultiplier;
			public bool dynamicBranchStiffOnlyWayBack;
			public bool alwaysApplyAngleLimitation;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				name = s.SerializeObject<StringID>(name, name: "name");
				polyline = s.SerializeObject<StringID>(polyline, name: "polyline");
				minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
				maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
				weight = s.Serialize<float>(weight, name: "weight");
				resistance = s.Serialize<float>(resistance, name: "resistance");
				hitForce = s.Serialize<float>(hitForce, name: "hitForce");
				windMultiplier = s.Serialize<float>(windMultiplier, name: "windMultiplier");
				weightMultiplier = s.Serialize<float>(weightMultiplier, name: "weightMultiplier");
				branchStiff = s.Serialize<float>(branchStiff, name: "branchStiff");
				branchDamping = s.Serialize<float>(branchDamping, name: "branchDamping");
				branchDelayMultiplier = s.Serialize<float>(branchDelayMultiplier, name: "branchDelayMultiplier");
				disableScale = s.Serialize<bool>(disableScale, name: "disableScale");
				disableCollision = s.Serialize<bool>(disableCollision, name: "disableCollision");
				useDynamicBranchStiff = s.Serialize<bool>(useDynamicBranchStiff, name: "useDynamicBranchStiff");
				dynamicBranchStiffMinAngle = s.SerializeObject<Angle>(dynamicBranchStiffMinAngle, name: "dynamicBranchStiffMinAngle");
				dynamicBranchStiffMaxAngle = s.SerializeObject<Angle>(dynamicBranchStiffMaxAngle, name: "dynamicBranchStiffMaxAngle");
				dynamicBranchStiffMultiplier = s.Serialize<float>(dynamicBranchStiffMultiplier, name: "dynamicBranchStiffMultiplier");
				dynamicBranchStiffOnlyWayBack = s.Serialize<bool>(dynamicBranchStiffOnlyWayBack, name: "dynamicBranchStiffOnlyWayBack");
				alwaysApplyAngleLimitation = s.Serialize<bool>(alwaysApplyAngleLimitation, name: "alwaysApplyAngleLimitation");
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
		public partial class PlatformData : CSerializable {
			public StringID poly;
			public StringID scale;
			public StringID link;
			public Angle maxPitch;
			public float minWeight;
			public float minWeightScale;
			public float maxWeight;
			public float maxWeightScale;
			public float MinScale;
			public float scaleStiff;
			public float scaleDamping;
			public float minWeightHinge;
			public bool disableCollision;
			public float hitForceMultiplier;
			public bool onlyCrushAttack;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				poly = s.SerializeObject<StringID>(poly, name: "poly");
				scale = s.SerializeObject<StringID>(scale, name: "scale");
				link = s.SerializeObject<StringID>(link, name: "link");
				maxPitch = s.SerializeObject<Angle>(maxPitch, name: "maxPitch");
				minWeight = s.Serialize<float>(minWeight, name: "minWeight");
				minWeightScale = s.Serialize<float>(minWeightScale, name: "minWeightScale");
				maxWeight = s.Serialize<float>(maxWeight, name: "maxWeight");
				maxWeightScale = s.Serialize<float>(maxWeightScale, name: "maxWeightScale");
				MinScale = s.Serialize<float>(MinScale, name: "MinScale");
				scaleStiff = s.Serialize<float>(scaleStiff, name: "scaleStiff");
				scaleDamping = s.Serialize<float>(scaleDamping, name: "scaleDamping");
				minWeightHinge = s.Serialize<float>(minWeightHinge, name: "minWeightHinge");
				disableCollision = s.Serialize<bool>(disableCollision, name: "disableCollision");
				hitForceMultiplier = s.Serialize<float>(hitForceMultiplier, name: "hitForceMultiplier");
				onlyCrushAttack = s.Serialize<bool>(onlyCrushAttack, name: "onlyCrushAttack");
			}
		}
		public override uint? ClassCRC => 0x0B2FF7DB;
	}
}

