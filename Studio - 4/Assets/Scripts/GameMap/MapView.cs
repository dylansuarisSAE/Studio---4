using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMap
{

    public class MapView : MonoBehaviour
    {
        public enum MapOrientation
        {
            BottomToTop,
            TopToBottom,
            RightToLeft,
            LeftToRight
        }

        public MapManager mapManager;
        public MapOrientation mapOrientation;

        [Tooltip("List of all the MapConfig scriptable objects from the " +
            "Assets folder that might be used to construct the maps. define general layout")]

       public List<MapConfig> allMapConfigs;
       public GameObject nodePrefab;

        [Tooltip("Offsets the start of the end nodes of the map form the edges of the screen")]

       public float orientationOffset;

        [Header("Background Settings")]
        [Tooltip("If the background sprite is null, the background will not be shown")]

       public Sprite background;
       public Color32 backgroundColor = Color.white;
       public float xSize;
       public float yOffset;

        [Header("Line Settings")]

       public GameObject linePrefab;

        [Tooltip("Line point count should be greater than 2 to get smooth color gradients")]

        [Range(3, 10)]

       public int linePointCount = 10;

        [Tooltip("The distance from the node till the Line starting point")]

       public float offsetFromNodes = 0.5f;

        [Header("Colors")]
        [Tooltip("Node Visited or Attainable color")]

       public Color32 visitedColor = Color.grey;

        [Tooltip("Locked node color")]

       public Color32 lockedColor = Color.white;

        [Tooltip("Node Visited or Attainable color")]

       public Color32 linevisitedColor = Color.grey;

        [Tooltip("Unavailable path color")]
       
       public Color32 lineLockedColor = Color.white;


       private GameObject firstParent;
       private GameObject mapParent;
       private List<List<Point>> paths;
       private Camera Cam;

       public readonly List<MapNode> nodes = new List<MapNode>();
       private readonly List<LineConnection> lineConnections = new List<LineConnection>();

       public static MapView Instance;

        private void Awake()
        {
            Instance = this;
            Cam = Camera.main;
        }

    }

}