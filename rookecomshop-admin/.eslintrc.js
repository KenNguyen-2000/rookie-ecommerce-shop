import pluginJs from '@eslint/js';
import tseslint from 'typescript-eslint';
import pluginReactConfig from 'eslint-plugin-react/configs/recommended.js';
import { fixupConfigRules } from '@eslint/compat';

export default {
	...pluginJs.confis.recommended,
	...tseslint.configs.recommended,
	...fixupConfigRules(pluginReactConfig),
	root: true,
	env: { browser: true, es2020: true },
	extends: ['eslint:recommended', 'plugin:@typescript-eslint/recommended', 'plugin:react-hooks/recommended'],
	ignorePatterns: ['dist', '.eslintrc.cjs'],
	parser: '@typescript-eslint/parser',
	plugins: ['react-refresh'],

	rules: {
		'react-refresh/only-export-components': ['warn', { allowConstantExport: true }],
		'no-unused-vars': 'warn',
		'no-undef': 'warn',
	},
};
