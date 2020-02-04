module Game

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open System

type Game1() as self =
    inherit Game()

    do self.Content.RootDirectory <- "Content"
    let graphics = new GraphicsDeviceManager(self)
    let mutable spriteBatch = Unchecked.defaultof<SpriteBatch>
    let mutable randomTexture = Unchecked.defaultof<Texture2D>

    override self.Initialize() =
        do spriteBatch <- new SpriteBatch(self.GraphicsDevice)
        graphics.PreferredBackBufferWidth <- 1024
        graphics.PreferredBackBufferHeight <- 768
        graphics.ApplyChanges()
        do base.Initialize()
        // TODO: Add your initialization logic here

        ()

    override self.LoadContent() =
        randomTexture <- self.Content.Load<Texture2D>("floor")

    override self.Update(gameTime) =()

    override self.Draw(gameTime) =
        do self.GraphicsDevice.Clear Color.Black
        spriteBatch.Begin()
        spriteBatch.Draw(randomTexture, Rectangle(50, 50, 50, 50), Color.White)
        spriteBatch.End()
