using System.Linq;

namespace UbiArt.ITF {
	public partial class TweenComponent {
		public void InstantiateFromTemplate(Context context, TweenComponent_Template template) {
			TweenInstruction InstantiateInstruction(TweenInstruction_Template ctpl) => ctpl?.Instantiate(context);
			instructionSets = new CListO<TweenComponent.InstructionSet>(template?.instructionSets?.Select(set => new TweenComponent.InstructionSet() {
				name = set?.name,
				instructions = new CArrayO<Generic<TweenInstruction>>(set?.instructions?.Select(c => new Generic<TweenInstruction>(InstantiateInstruction(c.obj)))?.ToArray())
			}).ToList());
		}
		public void InstantiateFromInstanceTemplate(Context context) {
			if (instanceTemplate?.value != null) {
				InstantiateFromTemplate(context, instanceTemplate.value);
			}
		}

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (instanceTemplate?.value != null) {
				if (s.SerializeEditorButton("Reset instructionSets based on instance template")) {
					InstantiateFromInstanceTemplate(s.Context);
				}
			}
		}
	}
}
