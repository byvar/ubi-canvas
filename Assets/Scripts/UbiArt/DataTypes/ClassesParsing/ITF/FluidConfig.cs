namespace UbiArt.ITF {
	public partial class FluidConfig {
		public FluidConfig() {
			Layers = new CListO<FluidFriseLayer>();
			Layers.Add(new FluidFriseLayer());
		}
	}
}
