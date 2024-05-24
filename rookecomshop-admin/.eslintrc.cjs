const pluginJs = require("'@eslint/js'");
const tseslint = require('typescript-eslint');
const pluginReactConfig = require('eslint-plugin-react/configs/recommended.js');
const { fixupConfigRules } = require('@eslint/compat');

module.exports = {
    ...pluginJs.confis.recommended,
    ...tseslint.configs.recommended,
    ...fixupConfigRules(pluginReactConfig),
    root: true,
    env: { browser: true, es2020: true },
    extends: [
        'eslint:recommended',
        'plugin:@typescript-eslint/recommended',
        'plugin:react-hooks/recommended',
    ],
    ignorePatterns: ['dist', '.eslintrc.cjs'],
    parser: '@typescript-eslint/parser',
    plugins: ['react-refresh'],

    rules: {
        'react-refresh/only-export-components': [
            'warn',
            { allowConstantExport: true },
        ],
        'no-unused-vars': 'warn',
        'no-undef': 'warn',
    },
};
