using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_CarnivorousLianaComponent_Template : ActorComponent_Template {
		public StringID defaultFxName;
		public float minLength;
		public float maxLength;
		public float extendSpeed;
		public float colapseSpeed;
		public float angularSpeedMax;
		public float angularRotationForSpeedMax;
		public float shakeDelayMin;
		public float shakeDelayMax;
		public float attackFinalDistanceCursor;
		public float noUserExtendDelay;
		public float timeToReachColapseSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			defaultFxName = s.SerializeObject<StringID>(defaultFxName, name: "defaultFxName");
			minLength = s.Serialize<float>(minLength, name: "minLength");
			maxLength = s.Serialize<float>(maxLength, name: "maxLength");
			extendSpeed = s.Serialize<float>(extendSpeed, name: "extendSpeed");
			colapseSpeed = s.Serialize<float>(colapseSpeed, name: "colapseSpeed");
			angularSpeedMax = s.Serialize<float>(angularSpeedMax, name: "angularSpeedMax");
			angularRotationForSpeedMax = s.Serialize<float>(angularRotationForSpeedMax, name: "angularRotationForSpeedMax");
			shakeDelayMin = s.Serialize<float>(shakeDelayMin, name: "shakeDelayMin");
			shakeDelayMax = s.Serialize<float>(shakeDelayMax, name: "shakeDelayMax");
			attackFinalDistanceCursor = s.Serialize<float>(attackFinalDistanceCursor, name: "attackFinalDistanceCursor");
			noUserExtendDelay = s.Serialize<float>(noUserExtendDelay, name: "noUserExtendDelay");
			timeToReachColapseSpeed = s.Serialize<float>(timeToReachColapseSpeed, name: "timeToReachColapseSpeed");
		}
		public override uint? ClassCRC => 0xD0923462;
	}
}

