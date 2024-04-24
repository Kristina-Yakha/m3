﻿using System;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    private int x;
    private int y;
    private Direction direction;

    public RobotSimulator(Direction direction, int x, int y)
    {
        this.x = x;
        this.y = y;
        this.direction = direction;

    }

    public Direction Direction
    {
        get
        {
            return direction;
        }
    }

    public int X
    {
        get
        {
            return x;
        }
    }

    public int Y
    {
        get
        {
            return y;
        }
    }

    public void TurnRight()
    {

        switch (direction)
        {
            case Direction.North:
                direction = Direction.East;
                break;
            case Direction.East:
                direction = Direction.South;
                break;
            case Direction.South:
                direction = Direction.West;
                break;
            case Direction.West:
                direction = Direction.North;
                break;

        }
    }

    public void TurnLeft()
    {

        switch (direction)
        {
            case Direction.North:
                direction = Direction.West;
                break;
            case Direction.West:
                direction = Direction.South;
                break;
            case Direction.South:
                direction = Direction.East;
                break;
            case Direction.East:
                direction = Direction.North;
                break;

        }

    }

    public void Advance()
    {

        switch (direction)
        {
            case Direction.North:
                y++;
                break;
            case Direction.West:
                x--;
                break;
            case Direction.South:
                y--;
                break;
            case Direction.East:
                x++;
                break;

        }
    }

    public void Move(string instructions)
    {
        char[] arr = instructions.ToCharArray();
        foreach (char instruction in instructions)
        {

            switch (instruction)
            {
                case 'R':
                    TurnRight();
                    break;
                case 'A':
                    Advance();
                    break;
                case 'L':
                    TurnLeft();
                    break;
            }
        }
    }
}























