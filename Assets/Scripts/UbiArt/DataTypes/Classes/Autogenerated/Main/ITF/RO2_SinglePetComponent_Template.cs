namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SinglePetComponent_Template : GraphicComponent_Template {
		public AABB aabb;
		public StringID appearAnim;
		public StringID moveAnim;
		public float punchForce;
		public float flipMinForce;
		public float flipMinDist;
		public float smoothFactor;
		public uint numTurns;
		public Path skullCoinPath;
		public Path redLumPath;
		public Vec2d offsetSkullCoin;
		public Vec2d offsetLum;
		public CListO<ModelParams> modelParams;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			aabb = s.SerializeObject<AABB>(aabb, name: "aabb");
			appearAnim = s.SerializeObject<StringID>(appearAnim, name: "appearAnim");
			moveAnim = s.SerializeObject<StringID>(moveAnim, name: "moveAnim");
			punchForce = s.Serialize<float>(punchForce, name: "punchForce");
			flipMinForce = s.Serialize<float>(flipMinForce, name: "flipMinForce");
			flipMinDist = s.Serialize<float>(flipMinDist, name: "flipMinDist");
			smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
			numTurns = s.Serialize<uint>(numTurns, name: "numTurns");
			skullCoinPath = s.SerializeObject<Path>(skullCoinPath, name: "skullCoinPath");
			redLumPath = s.SerializeObject<Path>(redLumPath, name: "redLumPath");
			offsetSkullCoin = s.SerializeObject<Vec2d>(offsetSkullCoin, name: "offsetSkullCoin");
			offsetLum = s.SerializeObject<Vec2d>(offsetLum, name: "offsetLum");
			modelParams = s.SerializeObject<CListO<ModelParams>>(modelParams, name: "modelParams");
		}
		public override uint? ClassCRC => 0xDA20F8D6;
	}
}

