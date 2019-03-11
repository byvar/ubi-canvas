using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TrainingTargetComponent_Template : ActorComponent_Template {
		[Serialize("feedbackActorPath" )] public Path feedbackActorPath;
		[Serialize("canBePainted"      )] public bool canBePainted;
		[Serialize("reward"            )] public uint reward;
		[Serialize("paintedReward"     )] public uint paintedReward;
		[Serialize("animOff"           )] public StringID animOff;
		[Serialize("animOffToOn"       )] public StringID animOffToOn;
		[Serialize("animOn"            )] public StringID animOn;
		[Serialize("animPainted"       )] public StringID animPainted;
		[Serialize("animExplode"       )] public StringID animExplode;
		[Serialize("animExplodePainted")] public StringID animExplodePainted;
		[Serialize("animAttack"        )] public StringID animAttack;
		[Serialize("fxBrickCompleted"  )] public StringID fxBrickCompleted;
		[Serialize("sendStim"          )] public bool sendStim;
		[Serialize("stimRadius"        )] public float stimRadius;
		[Serialize("stimOffset"        )] public Vector2 stimOffset;
		[Serialize("faction"           )] public uint faction;
		[Serialize("offAlphaValue"     )] public float offAlphaValue;
		[Serialize("alphaLerpFactor"   )] public float alphaLerpFactor;
		[Serialize("crushSensitive"    )] public bool crushSensitive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(feedbackActorPath));
			SerializeField(s, nameof(canBePainted));
			SerializeField(s, nameof(reward));
			SerializeField(s, nameof(paintedReward));
			SerializeField(s, nameof(animOff));
			SerializeField(s, nameof(animOffToOn));
			SerializeField(s, nameof(animOn));
			SerializeField(s, nameof(animPainted));
			SerializeField(s, nameof(animExplode));
			SerializeField(s, nameof(animExplodePainted));
			SerializeField(s, nameof(animAttack));
			SerializeField(s, nameof(fxBrickCompleted));
			SerializeField(s, nameof(sendStim));
			SerializeField(s, nameof(stimRadius));
			SerializeField(s, nameof(stimOffset));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(offAlphaValue));
			SerializeField(s, nameof(alphaLerpFactor));
			SerializeField(s, nameof(crushSensitive));
		}
		public override uint? ClassCRC => 0xA1A69415;
	}
}

