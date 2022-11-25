
namespace UbiArt.ITF {
	public partial class RO2_BTAIComponent_Template {
		public RO2_BTAIComponent_Template() {
			damageLevels = new CArrayP<uint>();
			damageLevels.SetContainer(new uint[] {
				5,
				25,
				50,
				100
			});
		}
	}
}
