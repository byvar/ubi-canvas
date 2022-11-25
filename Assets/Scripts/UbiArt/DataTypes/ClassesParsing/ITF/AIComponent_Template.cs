
namespace UbiArt.ITF {
	public partial class AIComponent_Template {
		public AIComponent_Template() {
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
