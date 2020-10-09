using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PrisonerCageComponent_Template : RO2_AIComponent_Template {
		public StringID animIdle;
		public StringID animExplode;
		public StringID tapSoundFXName;
		public StringID grabSoundFXName;
		public StringID landFX;
		public float speedMultiplier;
		public Vec2d forceSinus;
		public float freqSinus;
		public bool isSpiky;
		public bool isGrabable;
		public CListO<StringID> snapBones;
		public float slingShotDetectionRadius;
		public bool enablePhysic;
		public bool useAutoRaymanZone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
			animExplode = s.SerializeObject<StringID>(animExplode, name: "animExplode");
			tapSoundFXName = s.SerializeObject<StringID>(tapSoundFXName, name: "tapSoundFXName");
			grabSoundFXName = s.SerializeObject<StringID>(grabSoundFXName, name: "grabSoundFXName");
			landFX = s.SerializeObject<StringID>(landFX, name: "landFX");
			speedMultiplier = s.Serialize<float>(speedMultiplier, name: "speedMultiplier");
			forceSinus = s.SerializeObject<Vec2d>(forceSinus, name: "forceSinus");
			freqSinus = s.Serialize<float>(freqSinus, name: "freqSinus");
			isSpiky = s.Serialize<bool>(isSpiky, name: "isSpiky");
			isGrabable = s.Serialize<bool>(isGrabable, name: "isGrabable");
			snapBones = s.SerializeObject<CListO<StringID>>(snapBones, name: "snapBones");
			slingShotDetectionRadius = s.Serialize<float>(slingShotDetectionRadius, name: "slingShotDetectionRadius");
			enablePhysic = s.Serialize<bool>(enablePhysic, name: "enablePhysic");
			useAutoRaymanZone = s.Serialize<bool>(useAutoRaymanZone, name: "useAutoRaymanZone");
		}
		public override uint? ClassCRC => 0x7698E7B6;
	}
}

