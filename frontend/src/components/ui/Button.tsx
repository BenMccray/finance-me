import React from "react";

interface ButtonProps {
  text: string;
  type?: "button" | "submit" | "reset";
  disabled?: boolean;
  onClick?: () => void;
}
/**
 * Button component for rendering a button with customizable properties.
 * @param text - The text to display on the button.
 * @param type - The type of the button, defaults to "button".
 * @param disabled - Whether the button is disabled, defaults to false.
 * @param onClick - The function to call when the button is clicked, defaults to a console log.
 * @returns button element with the specified properties.
 * @example
 *  <Button type="submit" disabled={false} onClick={() => console.log("Submitted")}>Submit</Button>
 */
const Button = ({ text, type, disabled, onClick }: ButtonProps) => {
  return (
    <button
      type={type || "button"}
      onClick={onClick || (() => console.log("Clicked"))}
      disabled={disabled || false}
    >
      {text}
    </button>
  );
};

export default Button;
