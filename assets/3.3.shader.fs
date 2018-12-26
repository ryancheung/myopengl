#version 330 core
out vec4 FragColor;
in vec4 ourColor;

void main()
{
    FragColor = vec4(ourColor.r * 0.299f, ourColor.g * 0.587f, ourColor.b * 0.114f, 1.0); 
    //FragColor = ourColor;
} 
