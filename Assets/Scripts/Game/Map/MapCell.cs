﻿using UnityEngine;
using System.Collections;

public struct MapCell
{
    // Row
	public int Row;
    
    // Col
	public int Col;
    
    // World Position of the center of the cell
    public Vector3 Pos;

	// Reference to the obstacle if there is any
	public MapObstacle Obstacle;
}
