using System;
using UnityEditor;
using UnityEngine;

namespace Editor.NodeGraph
{
	public class RoomNodeGraphEditor : EditorWindow
	{
		private GUIStyle _roomNodeStyle;
		
		private const float NODE_WIDTH = 160f;
		private const float NODE_HEIGHT = 75f;
		private const int NODE_PADDING = 25;
		private const int NODE_BORDER = 12;

		[MenuItem("Room Node Graph Editor", menuItem = "Window/Dungeon Editor/Room Node Graph Editor")]
		private static void OpenWindow()
		{
			string windowTitle = "Room Node Graph Editor";
			GetWindow<RoomNodeGraphEditor>(windowTitle);
		}

		private void OnEnable()
		{
			// Define node layout style
			_roomNodeStyle = new GUIStyle();
			_roomNodeStyle.normal.background = EditorGUIUtility.Load("node1") as Texture2D;
			_roomNodeStyle.normal.textColor = Color.white;
			_roomNodeStyle.padding = new RectOffset(NODE_PADDING, NODE_PADDING, NODE_PADDING, NODE_PADDING);
			_roomNodeStyle.border = new RectOffset (NODE_BORDER, NODE_BORDER, NODE_BORDER, NODE_BORDER);
		}

		private void OnGUI()
		{
			GUILayout. BeginArea(new Rect(new Vector2(100f, 100f),
                              new Vector2(NODE_WIDTH, NODE_HEIGHT)),
								_roomNodeStyle);
			
			EditorGUILayout. LabelField("Node 1");
			GUILayout. EndArea();
			
			GUILayout.BeginArea(new Rect(new Vector2(300f, 300f),
	                             new Vector2(NODE_WIDTH, NODE_HEIGHT)),
								_roomNodeStyle);
			
			EditorGUILayout. LabelField("Node 2");
			GUILayout.EndArea();
		}
	}
}