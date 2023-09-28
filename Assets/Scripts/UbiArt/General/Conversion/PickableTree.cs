using System.Collections.Generic;
using UbiArt.ITF;

namespace UbiArt {
	public class PickableTree {
		public Node Root { get; }

		public PickableTree(Scene scene) {
			Root = new Node(scene, null);
		}

		/*public bool SearchForPickable(Pickable start, Pickable toFind) {
		}
		public bool SearchForPickable(Scene start, Pickable toFind) {
		}
		public bool SearchForPickable(Node start, Pickable toFind) {
		}*/
		public Node FollowObjectPath(ObjectPath start, ObjectPath toFind, bool throwIfNotFound = true) {
			var startNode = Root.GetNodeWithObjectPath(start, throwIfNotFound: throwIfNotFound);
			//UnityEngine.Debug.Log(startNode.Pickable?.USERFRIENDLY ?? "null");
			return startNode.Parent.GetNodeWithObjectPath(toFind, throwIfNotFound: throwIfNotFound);
		}
		public Node FollowObjectPath(ObjectPath toFind, bool throwIfNotFound = true) {
			return Root.GetNodeWithObjectPath(toFind, throwIfNotFound: throwIfNotFound);
		}

		public class Node {
			public Scene Scene { get; }
			public Pickable Pickable { get; }
			public Dictionary<string, Node> Children { get; } = new Dictionary<string, Node>();
			public Node Parent { get; }

			public Node(Pickable pickable, Node parent) {
				Pickable = pickable;
				Parent = parent;
				if (pickable is SubSceneActor ssa && ssa.SCENE?.value != null) {
					Scene = ssa.SCENE.value;
					AddChildren();
				}
			}

			public Node(Scene scene, Node parent) {
				Parent = parent;
				Scene = scene;
				if(Scene != null)
					AddChildren();
			}

			void AddChildren() {
				if (Scene.ACTORS != null) {
					foreach (var a in Scene.ACTORS) {
						if (a.obj == null || a.obj.USERFRIENDLY == null) continue;
						Children.Add(a.obj.USERFRIENDLY, new Node(a.obj, this));
					}
				}
				if (Scene.FRISE != null) {
					foreach (var f in Scene.FRISE) {
						if (f == null || f.USERFRIENDLY == null) continue;
						Children.Add(f.USERFRIENDLY, new Node(f, this));
					}
				}
			}

			public Node GetNodeWithObjectPath(ObjectPath path, int levelsProcessed = 0, bool throwIfNotFound = true) {
				if((path == null) || ((path.levels == null || path.levels.Count == 0) && string.IsNullOrEmpty(path.id)))
					return null;

				if (path.levels != null && levelsProcessed < path.levels.Count) {
					var curLevel = path.levels[levelsProcessed];
					if(curLevel.parent)
						return Parent?.GetNodeWithObjectPath(path, levelsProcessed: levelsProcessed + 1, throwIfNotFound: throwIfNotFound);
					if (Children.TryGetValue(curLevel.name, out Node levelNode)) {
						return levelNode?.GetNodeWithObjectPath(path, levelsProcessed: levelsProcessed + 1, throwIfNotFound: throwIfNotFound);
					} else {
						if (throwIfNotFound) {
							throw new KeyNotFoundException($"Could not resolve ObjectPath with level name {curLevel.name}");
						}
						return null;
					}
				}

				if(string.IsNullOrEmpty(path.id))
					return null;

				if (Children.TryGetValue(path.id, out Node node)) {
					return node;
				} else {
					if (throwIfNotFound) {
						throw new KeyNotFoundException($"Could not resolve ObjectPath with id {path.id}");
					}
					return null;
				}

			}
		}
	}
}
