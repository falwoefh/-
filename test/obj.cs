/// step - STATE CONTROLLER
// 1. input
inputW = keyboard_check_pressed(ord("W"));
inputA = keyboard_check(ord("A"));
inputS = keyboard_check_pressed(ord("S"));
inputD = keyboard_check(ord("D"));
inputShift = keyboard_check(vk_shift);
inputRelS = keyboard_check_released(ord("S"));
inputSpace = keyboard_check_pressed(vk_space);

// 4. Physics
if moveY < 10 {
    moveY = min(moveY+grav, 9);
}
// 5. collision check
if place_meeting(x,y,o_ground) {
        repeat (abs(moveY)){
    if not place_meeting(x,y+sign(y),o_ground){
        y += sign(moveY);
    }
        }
    moveY = 0 
}
// 2. state change
if state == "idle" {
    sprite_index = s_player_idle;
    image_speed = 1/3;

   if inputW {
        moveY = -12;
    }

    if inputA or inputD{
        state = "move";
    }
    if inputS {
        state = "crouch";
    }
}
else if state == "move" {
    sprite_index = s_player_move;
    if inputD + inputA == 0 {
        state = "idle";
    } 
    moveX = (inputD - inputA) * my_spd;
}
else if state = "crouch" {
    sprite_index = s_crouch;
    if inputRelS {
        state = "idle";
    }
}
// 3. Apply
y += moveY;
x += moveX;

/// Sprite Controller
if moveX < 0 {
    image_xscale = -1;
} else if moveX > 0 {
    image_xscale = 1;
}
