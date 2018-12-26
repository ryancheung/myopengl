#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture sampler
uniform sampler2D texture1;

void main()
{
	FragColor = texture(texture1, TexCoord);
    float v = FragColor.r * 0.21f + FragColor.g * 0.72f + FragColor.b * 0.07f;
    FragColor = vec4(v, v, v, 1.0f);
}
