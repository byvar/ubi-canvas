namespace UbiArt.ITF {
	public partial class FluidConfig {
		public FluidConfig() {
			Elasticity = 0.98f;
			Velocity = 0.04f;
			Viscosity = 0.05f;
			Amplification = 0.01f;
			TargetHeight = 0.5f;
			TargetAddHeight = -0.005f;
			TargetMaxHeight = 1f;
			PolylineUnityMult = 1;
			UnityWidth = 0.1f;
			MaxDstInfluence = 1f;
			EnterMult = 10f;
			LeaveMult = 10f;
			InfluenceLimit = 3.402823e+38F;
			WeightMultiplier = 0.03f;
			PerpendicularBackScale = 1f;
			PerpendicularFrontScale = 1f;
			PerpendicularBackPos = 1f;
			PerpendicularFrontPos = 1f;
			dstInfluenceMultiplier = 1f;
			LayerCount = 1;
			SideCount = 1;
			PolylineReaction = true;
		}
	}
}
