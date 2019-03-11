using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_GolemAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("countDownAttack"     )] public float countDownAttack;
		[Serialize("timeAnticipation"    )] public float timeAnticipation;
		[Serialize("gravityBallistics"   )] public float gravityBallistics;
		[Serialize("timeExpulse"         )] public float timeExpulse;
		[Serialize("powerExpulse"        )] public float powerExpulse;
		[Serialize("zOffsetExpulse"      )] public float zOffsetExpulse;
		[Serialize("angleRotateExpulse"  )] public Angle angleRotateExpulse;
		[Serialize("factorSmoothPupil"   )] public float factorSmoothPupil;
		[Serialize("actEyeBrow_Left"     )] public Path actEyeBrow_Left;
		[Serialize("boneEyeBrow_Left"    )] public StringID boneEyeBrow_Left;
		[Serialize("zOffsetEyeBrow_Left" )] public float zOffsetEyeBrow_Left;
		[Serialize("actEyeBrow_Right"    )] public Path actEyeBrow_Right;
		[Serialize("boneEyeBrow_Right"   )] public StringID boneEyeBrow_Right;
		[Serialize("zOffsetEyeBrow_Right")] public float zOffsetEyeBrow_Right;
		[Serialize("actEye_Left"         )] public Path actEye_Left;
		[Serialize("boneEye_Left"        )] public StringID boneEye_Left;
		[Serialize("zOffsetEye_Left"     )] public float zOffsetEye_Left;
		[Serialize("actEye_Right"        )] public Path actEye_Right;
		[Serialize("boneEye_Right"       )] public StringID boneEye_Right;
		[Serialize("zOffsetEye_Right"    )] public float zOffsetEye_Right;
		[Serialize("actNose"             )] public Path actNose;
		[Serialize("boneNose"            )] public StringID boneNose;
		[Serialize("zOffsetNose"         )] public float zOffsetNose;
		[Serialize("musics"              )] public Placeholder musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(countDownAttack));
			SerializeField(s, nameof(timeAnticipation));
			SerializeField(s, nameof(gravityBallistics));
			SerializeField(s, nameof(timeExpulse));
			SerializeField(s, nameof(powerExpulse));
			SerializeField(s, nameof(zOffsetExpulse));
			SerializeField(s, nameof(angleRotateExpulse));
			SerializeField(s, nameof(factorSmoothPupil));
			SerializeField(s, nameof(actEyeBrow_Left));
			SerializeField(s, nameof(boneEyeBrow_Left));
			SerializeField(s, nameof(zOffsetEyeBrow_Left));
			SerializeField(s, nameof(actEyeBrow_Right));
			SerializeField(s, nameof(boneEyeBrow_Right));
			SerializeField(s, nameof(zOffsetEyeBrow_Right));
			SerializeField(s, nameof(actEye_Left));
			SerializeField(s, nameof(boneEye_Left));
			SerializeField(s, nameof(zOffsetEye_Left));
			SerializeField(s, nameof(actEye_Right));
			SerializeField(s, nameof(boneEye_Right));
			SerializeField(s, nameof(zOffsetEye_Right));
			SerializeField(s, nameof(actNose));
			SerializeField(s, nameof(boneNose));
			SerializeField(s, nameof(zOffsetNose));
			SerializeField(s, nameof(musics));
		}
		public override uint? ClassCRC => 0xE1BA946D;
	}
}

