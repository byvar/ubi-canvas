using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SinglePetComponent_Template : GraphicComponent_Template {
		[Serialize("aabb"           )] public AABB aabb;
		[Serialize("appearAnim"     )] public StringID appearAnim;
		[Serialize("moveAnim"       )] public StringID moveAnim;
		[Serialize("punchForce"     )] public float punchForce;
		[Serialize("flipMinForce"   )] public float flipMinForce;
		[Serialize("flipMinDist"    )] public float flipMinDist;
		[Serialize("smoothFactor"   )] public float smoothFactor;
		[Serialize("numTurns"       )] public uint numTurns;
		[Serialize("skullCoinPath"  )] public Path skullCoinPath;
		[Serialize("redLumPath"     )] public Path redLumPath;
		[Serialize("offsetSkullCoin")] public Vec2d offsetSkullCoin;
		[Serialize("offsetLum"      )] public Vec2d offsetLum;
		[Serialize("modelParams"    )] public CList<ModelParams> modelParams;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(aabb));
			SerializeField(s, nameof(appearAnim));
			SerializeField(s, nameof(moveAnim));
			SerializeField(s, nameof(punchForce));
			SerializeField(s, nameof(flipMinForce));
			SerializeField(s, nameof(flipMinDist));
			SerializeField(s, nameof(smoothFactor));
			SerializeField(s, nameof(numTurns));
			SerializeField(s, nameof(skullCoinPath));
			SerializeField(s, nameof(redLumPath));
			SerializeField(s, nameof(offsetSkullCoin));
			SerializeField(s, nameof(offsetLum));
			SerializeField(s, nameof(modelParams));
		}
		public override uint? ClassCRC => 0xDA20F8D6;
	}
}

