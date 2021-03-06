﻿module MarsBaseBuilder.GameLogic

open Microsoft.Xna.Framework

open MarsBaseBuilder.Measures

type GameState = 
    { units : Map<GameUnit, PhysicalTransform> }

let private units = 
    [| Base, origin
       Builder, { position = pp 30 30; rotation = deg 30.0f } |]

let newMission = { units = Map(units) }

let update (state : GameState) (timeDelta : GameTime) : GameState = state
