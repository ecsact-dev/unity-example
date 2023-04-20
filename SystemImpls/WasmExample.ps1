$EcsactInc = (ecsact config include_dir)
emcc -O2 -std=c++20 --no-entry -I"$EcsactInc" `
     -sEXPORTED_FUNCTIONS="_example__PerformGenerateBlock,_example__GenerateBlock,_example__AddToExample,_example__Move,_example__ApplyVelocity,_example__CollisionComparer__CheckCollision" `
     -sERROR_ON_UNDEFINED_SYMBOLS=0 `
     -Wno-js-compiler `
     -o ../Assets/Scripts/Systems/UnityExamples.wasm `
     generate_block_system.cc `
     basic_example.cc `
     move.cc `
     collision.cc `
     example.ecsact.systems.cc