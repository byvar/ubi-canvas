using System.Linq;

namespace UbiArt.ITF {
	public partial class BTAIComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if ((oldSettings.Game == Game.RA || oldSettings.Game == Game.RM) && newSettings.Game == Game.RL) {
				var root = behaviorTree.root?.node?.obj;
				if (behaviorTree != null) {
					if (this is RO2_EnemyBTAIComponent_Template enemy && enemy.canSwim) {
						// Remove drown nodes if the enemy can swim
						var drown = new StringID("Drown");
						if (root != null) {
							if (root is BTDecider_Template dec) {
								dec.nodes = new CListO<BTNodeTemplate_Ref>(dec.nodes.Where(n => n.nameId != drown && n.node?.obj?.name != drown).ToList());
							}
						}
						if (behaviorTree.nodes != null) {
							behaviorTree.nodes = new CArrayO<Generic<BTNode_Template>>(behaviorTree.nodes.Where(n => n?.obj?.name != drown).ToArray());
							foreach (var node in behaviorTree.nodes) {
								if(node == null) continue;

								if (node?.obj is BTDecider_Template dec) {
									if (dec?.nodes == null) continue;
									dec.nodes = new CListO<BTNodeTemplate_Ref>(dec.nodes.Where(n => n.nameId != drown && n.node?.obj?.name != drown).ToList());

								}
							}
						}
					}
				}
				CListO<BTNodeTemplate_Ref> nodesToCopy = null;
				if (root is BTDecider_Template rootDec) {
					for(int i = 0; i < rootDec.nodes.Count; i++) {
						var rootNode = rootDec.nodes[i];
						var name = rootNode.nameId;
						Generic<BTNode_Template> treeNode = null;
						if (name == null || name.IsNull) {
							treeNode = rootNode.node;
						} else {
							treeNode = behaviorTree.nodes.FirstOrDefault(n => n.obj.name == name);
						}
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
