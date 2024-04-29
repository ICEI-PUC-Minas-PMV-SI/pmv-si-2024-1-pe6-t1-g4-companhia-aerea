/* eslint-disable react/prop-types */
function Select({ options, onChange, value, placeholder }) {
    return (
      <select onChange={onChange} value={value}>
        {placeholder && (
        <option value="" disabled hidden>
          {placeholder}
        </option>
      )}
        {options.map((option, index) => (
          <option key={index} value={option.value}>
            {option.label}
          </option>
        ))}
      </select>
    );
  }

export default Select;