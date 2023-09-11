namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_GolemAIComponent_Template : RO2_AIComponent_Template {
		public float countDownAttack;
		public float timeAnticipation;
		public float gravityBallistics;
		public float timeExpulse;
		public float powerExpulse;
		public float zOffsetExpulse;
		public Angle angleRotateExpulse;
		public float factorSmoothPupil;
		public Path actEyeBrow_Left;
		public StringID boneEyeBrow_Left;
		public float zOffsetEyeBrow_Left;
		public Path actEyeBrow_Right;
		public StringID boneEyeBrow_Right;
		public float zOffsetEyeBrow_Right;
		public Path actEye_Left;
		public StringID boneEye_Left;
		public float zOffsetEye_Left;
		public Path actEye_Right;
		public StringID boneEye_Right;
		public float zOffsetEye_Right;
		public Path actNose;
		public StringID boneNose;
		public float zOffsetNose;
		public CListO<EventPlayMusic> musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				countDownAttack = s.Serialize<float>(countDownAttack, name: "countDownAttack");
				timeAnticipation = s.Serialize<float>(timeAnticipation, name: "timeAnticipation");
				gravityBallistics = s.Serialize<float>(gravityBallistics, name: "gravityBallistics");
				timeExpulse = s.Serialize<float>(timeExpulse, name: "timeExpulse");
				powerExpulse = s.Serialize<float>(powerExpulse, name: "powerExpulse");
				zOffsetExpulse = s.Serialize<float>(zOffsetExpulse, name: "zOffsetExpulse");
				angleRotateExpulse = s.SerializeObject<Angle>(angleRotateExpulse, name: "angleRotateExpulse");
				factorSmoothPupil = s.Serialize<float>(factorSmoothPupil, name: "factorSmoothPupil");
				actEyeBrow_Left = s.SerializeObject<Path>(actEyeBrow_Left, name: "actEyeBrow_Left");
				boneEyeBrow_Left = s.SerializeObject<StringID>(boneEyeBrow_Left, name: "boneEyeBrow_Left");
				zOffsetEyeBrow_Left = s.Serialize<float>(zOffsetEyeBrow_Left, name: "zOffsetEyeBrow_Left");
				actEyeBrow_Right = s.SerializeObject<Path>(actEyeBrow_Right, name: "actEyeBrow_Right");
				boneEyeBrow_Right = s.SerializeObject<StringID>(boneEyeBrow_Right, name: "boneEyeBrow_Right");
				zOffsetEyeBrow_Right = s.Serialize<float>(zOffsetEyeBrow_Right, name: "zOffsetEyeBrow_Right");
				actEye_Left = s.SerializeObject<Path>(actEye_Left, name: "actEye_Left");
				boneEye_Left = s.SerializeObject<StringID>(boneEye_Left, name: "boneEye_Left");
				zOffsetEye_Left = s.Serialize<float>(zOffsetEye_Left, name: "zOffsetEye_Left");
				actEye_Right = s.SerializeObject<Path>(actEye_Right, name: "actEye_Right");
				boneEye_Right = s.SerializeObject<StringID>(boneEye_Right, name: "boneEye_Right");
				zOffsetEye_Right = s.Serialize<float>(zOffsetEye_Right, name: "zOffsetEye_Right");
				actNose = s.SerializeObject<Path>(actNose, name: "actNose");
				boneNose = s.SerializeObject<StringID>(boneNose, name: "boneNose");
				zOffsetNose = s.Serialize<float>(zOffsetNose, name: "zOffsetNose");
				musics = s.SerializeObject<CListO<EventPlayMusic>>(musics, name: "musics");
			} else {
				countDownAttack = s.Serialize<float>(countDownAttack, name: "countDownAttack");
				timeAnticipation = s.Serialize<float>(timeAnticipation, name: "timeAnticipation");
				gravityBallistics = s.Serialize<float>(gravityBallistics, name: "gravityBallistics");
				timeExpulse = s.Serialize<float>(timeExpulse, name: "timeExpulse");
				powerExpulse = s.Serialize<float>(powerExpulse, name: "powerExpulse");
				zOffsetExpulse = s.Serialize<float>(zOffsetExpulse, name: "zOffsetExpulse");
				angleRotateExpulse = s.SerializeObject<Angle>(angleRotateExpulse, name: "angleRotateExpulse");
				factorSmoothPupil = s.Serialize<float>(factorSmoothPupil, name: "factorSmoothPupil");
				actEyeBrow_Left = s.SerializeObject<Path>(actEyeBrow_Left, name: "actEyeBrow_Left");
				boneEyeBrow_Left = s.SerializeObject<StringID>(boneEyeBrow_Left, name: "boneEyeBrow_Left");
				zOffsetEyeBrow_Left = s.Serialize<float>(zOffsetEyeBrow_Left, name: "zOffsetEyeBrow_Left");
				actEyeBrow_Right = s.SerializeObject<Path>(actEyeBrow_Right, name: "actEyeBrow_Right");
				boneEyeBrow_Right = s.SerializeObject<StringID>(boneEyeBrow_Right, name: "boneEyeBrow_Right");
				zOffsetEyeBrow_Right = s.Serialize<float>(zOffsetEyeBrow_Right, name: "zOffsetEyeBrow_Right");
				actEye_Left = s.SerializeObject<Path>(actEye_Left, name: "actEye_Left");
				boneEye_Left = s.SerializeObject<StringID>(boneEye_Left, name: "boneEye_Left");
				zOffsetEye_Left = s.Serialize<float>(zOffsetEye_Left, name: "zOffsetEye_Left");
				actEye_Right = s.SerializeObject<Path>(actEye_Right, name: "actEye_Right");
				boneEye_Right = s.SerializeObject<StringID>(boneEye_Right, name: "boneEye_Right");
				zOffsetEye_Right = s.Serialize<float>(zOffsetEye_Right, name: "zOffsetEye_Right");
				actNose = s.SerializeObject<Path>(actNose, name: "actNose");
				boneNose = s.SerializeObject<StringID>(boneNose, name: "boneNose");
				zOffsetNose = s.Serialize<float>(zOffsetNose, name: "zOffsetNose");
			}
		}
		public override uint? ClassCRC => 0x118EDBB3;
	}
}

