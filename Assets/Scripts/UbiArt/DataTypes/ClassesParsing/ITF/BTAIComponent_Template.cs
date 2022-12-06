using System.Linq;

namespace UbiArt.ITF {
	public partial class BTAIComponent_Template {
		public override ActorComponent_Template Convert(Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
			if ((oldSettings.game == Settings.Game.RA || oldSettings.game == Settings.Game.RM) && newSettings.game == Settings.Game.RL) {
				var root = behaviorTree.root?.node?.obj;
				CListO<BTNodeTemplate_Ref> nodesToCopy = null;
				if (root is BTDecider_Template rootDec) {
					for(int i = 0; i < rootDec.nodes.Count; i++) {
						var rootNode = rootDec.nodes[i];
						var name = rootNode.nameId;
						var treeNode = behaviorTree.nodes.FirstOrDefault(n => n.obj.name == name);
						if (treeNode == null) {
							UbiArtContext?.SystemLogger?.LogWarning($"BTAI tree conversion: Node with name {name} was not found");
							continue;
						}
						if (nodesToCopy == null) {
							if (treeNode.obj is BTDeciderHasFact_Template factDecider) {
								var factToRemove = new StringID(0x84E2B5AB); // "Got Hurt" fact
								if (factDecider.factsHave?.Contains(factToRemove) ?? false) {
									//factDecider.factsHave.Remove(factToRemove);
									if (factDecider.factsHave.Count == 1) {
										// Now merge all nodes in this with all following deciders
										nodesToCopy = factDecider.nodes;
									}
								}
							}
						} else {
							if (treeNode.obj is BTDecider_Template decider) {
								var oldNodes = decider.nodes;
								decider.nodes = new CListO<BTNodeTemplate_Ref>();
								foreach (var n in nodesToCopy) decider.nodes.Add(n);
								foreach (var n in oldNodes) decider.nodes.Add(n);
							}
						}
					}
				}
			}
			return this;
		}
	}
}
